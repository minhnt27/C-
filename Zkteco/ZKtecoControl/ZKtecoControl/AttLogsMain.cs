﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SQLite;
using System.Data.SqlClient;

namespace ZKtecoControl
{

    public partial class AttLogsMain : Form
    {
        public AttLogsMain()
        {
            InitializeComponent();

            //Initialize DataBase
            lbdbver.Text = table_Setup();
        }

        public string table_Setup()
        {
            string result = "DB not connected";
            string connString = @"Data Source=" + this.datasource + ";Initial Catalog=" + this.database + ";Persist Security Info=True;User ID=" + this.username + ";Password=" + this.password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT @@version";
                result = "Db version: " + (string)cmd.ExecuteScalar(); //ExecuteScalar(): return first colunm of first row in the result set returned by the query


                //cmd.CommandText = "DROP TABLE IF EXISTS UserLock";
                //cmd.ExecuteNonQuery();

                cmd.CommandText = //@"CREATE TABLE UserLock(id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, teamid INT, checkin TEXT, checkout TEXT, passcode TEXT, asignto TEXT, finish TEXT)";
                @"if not exists(select * from sysobjects where name = 'vehicle' and xtype = 'U')
                    CREATE TABLE UserLock(id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY, teamid INT, checkin TEXT, checkout TEXT, passcode TEXT, asignto TEXT, finish TEXT)
                go";
                cmd.ExecuteNonQuery();

                cmd.CommandText = //@"CREATE TABLE UserLog(id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, count INT, enrollnumber TEXT, verifymode INT, inoutmode TEXT, date TEXT, workcode TEXT)";
                @"if not exists(select * from sysobjects where name = 'vehicle' and xtype = 'U')
                    CREATE TABLE UserLog(id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, count INT, enrollnumber TEXT, verifymode INT, inoutmode TEXT, date TEXT, workcode TEXT)
                go";
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
            }
            return result;
        }

        //Create Standalone SDK class dynamicaly.
        public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();

        //DB connection info
        public string datasource = "WIN-AL49731RE58\\SQLEXPRESS";
        public string database = "mylab";
        public string username = "sa";
        public string password = "123456a@";

        public long t = 0;
        /********************************************************************************************************************************************
        * Before you refer to this demo,we strongly suggest you read the development manual deeply first.                                           *
        * This part is for demonstrating the communication with your device.There are 3 communication ways: "TCP/IP","Serial Port" and "USB Client".*
        * The communication way which you can use duing to the model of the device.                                                                 *
        * *******************************************************************************************************************************************/
        #region Communication
        private bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private int iMachineNumber = 1;//the serial number of the device.After connecting the device ,this value will be changed.

        //If your device supports the TCP/IP communications, you can refer to this.
        //when you are using the tcp/ip communication,you can distinguish different devices by their IP address.
        private void button1_Click(object sender, EventArgs e)
        {                       
            if (txtIP.Text.Trim() == "" || txtPort.Text.Trim() == "")
            {
                MessageBox.Show("IP and Port cannot be null", "Error");
                return;
            }
            int idwErrorCode = 0;

            Cursor = Cursors.WaitCursor;
            if (btnConnect.Text == "DisConnect")
            {
                axCZKEM1.Disconnect();
                bIsConnected = false;
                btnConnect.Text = "Connect";
                lblState.Text = "Current State:DisConnected";
                Cursor = Cursors.Default;

                return;
            }

            bIsConnected = axCZKEM1.Connect_Net(txtIP.Text, Convert.ToInt32(txtPort.Text));
            if (bIsConnected == true)
            {
                btnConnect.Text = "DisConnect";
                btnConnect.Refresh();
                lblState.Text = "Current State:Connected";
                iMachineNumber = 1;//In fact,when you are using the tcp/ip communication,this parameter will be ignored,that is any integer will all right.Here we use 1.
                axCZKEM1.RegEvent(iMachineNumber, 65535);//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
                                                         //MessageBox.Show("Machine serial: " + iMachineNumber.ToString(), "Info");

            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Unable to connect the device,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            Cursor = Cursors.Default;
        }

        #endregion



        #region AttLogs
        private void btnGetGeneralLogData_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first", "Error");
                return;
            }

            string sdwEnrollNumber = "";
            //int idwTMachineNumber = 0;
            //int idwEMachineNumber = 0;
            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            int idwYear = 0;
            int idwMonth = 0;
            int idwDay = 0;
            int idwHour = 0;
            int idwMinute = 0;
            int idwSecond = 0;
            int idwWorkcode = 0;

            int idwErrorCode = 0;
            int iGLCount = 0;
            int iIndex = 0;

            Cursor = Cursors.WaitCursor;
            lvLogs.Items.Clear();
            axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
            if (axCZKEM1.ReadGeneralLogData(iMachineNumber))//read all the attendance records to the memory
            {
                while (axCZKEM1.SSR_GetGeneralLogData(iMachineNumber, out sdwEnrollNumber, out idwVerifyMode,
                           out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
                {
                    iGLCount++;
                    lvLogs.Items.Add(iGLCount.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(sdwEnrollNumber);//modify by Darcy on Nov.26 2009
                    lvLogs.Items[iIndex].SubItems.Add(idwVerifyMode.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwInOutMode.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString());
                    lvLogs.Items[iIndex].SubItems.Add(idwWorkcode.ToString());
                    iIndex++;

                    //insert to db
                    
                    /*
                    //string cs = @"URI=file:E:\Lab\Demo\sqlite\db\sqlite\testDB.db";

                    SQLiteConnection con = new SQLiteConnection(cs);
                    con.Open();

                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "INSERT INTO AttLog(count, enrollnumber, verifymode, inoutmode, date, workcode) VALUES(@count, @enrollnumber, @verifymode, @inoutmode, @date, @workcode)";
                    
                    cmd.Parameters.AddWithValue("@count", iGLCount.ToString());
                    cmd.Parameters.AddWithValue("@enrollnumber", sdwEnrollNumber);
                    cmd.Parameters.AddWithValue("@verifymode", idwVerifyMode.ToString());
                    cmd.Parameters.AddWithValue("@inoutmode", idwInOutMode.ToString());
                    cmd.Parameters.AddWithValue("@date", idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString() + ":" + idwSecond.ToString());
                    cmd.Parameters.AddWithValue("@workcode", idwWorkcode.ToString());
                    cmd.Prepare();

                    cmd.ExecuteNonQuery();

                    con.Close();
                    */
                }
            }
            else
            {
                Cursor = Cursors.Default;
                axCZKEM1.GetLastError(ref idwErrorCode);

                if (idwErrorCode != 0)
                {
                    MessageBox.Show("Reading data from terminal failed,ErrorCode: " + idwErrorCode.ToString(), "Error");
                }
                else
                {
                    MessageBox.Show("No data from terminal returns!", "Error");
                }
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            Cursor = Cursors.Default;
        }

        #endregion



        #region Card Operation
        private void btnGetStrCardNumber_Click(object sender, EventArgs e)
        {
            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            string sdwEnrollNumber = "";
            string sName = "";
            string sPassword = "";
            int iPrivilege = 0;
            bool bEnabled = false;
            string sCardnumber = "";

            lvCard.Items.Clear();
            lvCard.BeginUpdate();
            Cursor = Cursors.WaitCursor;
            axCZKEM1.EnableDevice(iMachineNumber, false);//disable the device
            axCZKEM1.ReadAllUserID(iMachineNumber);//read all the user information to the memory
            while (axCZKEM1.SSR_GetAllUserInfo(iMachineNumber, out sdwEnrollNumber, out sName, out sPassword, out iPrivilege, out bEnabled))//get user information from memory
            {
                if (axCZKEM1.GetStrCardNumber(out sCardnumber))//get the card number from the memory
                {
                    ListViewItem list = new ListViewItem();
                    list.Text = sdwEnrollNumber;
                    list.SubItems.Add(sName);
                    list.SubItems.Add(sCardnumber);
                    list.SubItems.Add(iPrivilege.ToString());
                    list.SubItems.Add(sPassword);
                    if (bEnabled == true)
                    {
                        list.SubItems.Add("true");
                    }
                    else
                    {
                        list.SubItems.Add("false");
                    }
                    lvCard.Items.Add(list);
                }
            }
            axCZKEM1.EnableDevice(iMachineNumber, true);//enable the device
            lvCard.EndUpdate();
            Cursor = Cursors.Default;
        }

        
        private void btnSetStrCardNumber_Click(object sender, EventArgs e)
        {

            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            if (txtUserID.Text.Trim() == "" || cbPrivilege.Text.Trim() == "" || txtCardnumber.Text.Trim() == "")
            {
                MessageBox.Show("UserID,Privilege,Cardnumber must be inputted first!", "Error");
                return;
            }
            int idwErrorCode = 0;

            bool bEnabled = true;
            if (chbEnabled.Checked)
            {
                bEnabled = true;
            }
            else
            {
                bEnabled = false;
            }
            string sdwEnrollNumber = txtUserID.Text.Trim();
            string sName = txtName.Text.Trim();
            string sPassword = txtPassword.Text.Trim();
            int iPrivilege = Convert.ToInt32(cbPrivilege.Text.Trim());
            string sCardnumber = txtCardnumber.Text.Trim();

            Cursor = Cursors.WaitCursor;
            axCZKEM1.EnableDevice(iMachineNumber, false);
            axCZKEM1.SetStrCardNumber(sCardnumber);//Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
            if (axCZKEM1.SSR_SetUserInfo(iMachineNumber, sdwEnrollNumber, sName, sPassword, iPrivilege, bEnabled))//upload the user's information(card number included)
            {
                MessageBox.Show("(SSR_)SetUserInfo,UserID:" + sdwEnrollNumber + " Privilege:" + iPrivilege.ToString() + " Enabled:" + bEnabled.ToString(), "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
            axCZKEM1.EnableDevice(iMachineNumber, true);
            Cursor = Cursors.Default;
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            string sEnabled = "";

            for (int i = 0; i < lvCard.Items.Count; i++)
            {
                if (txtUserID.Text.Trim()!="" && (Convert.ToInt32(txtUserID.Text.Trim()) == Convert.ToInt32(lvCard.Items[i].SubItems[0].Text.Trim())))
                {
                    txtName.Text = lvCard.Items[i].SubItems[1].Text.Trim();
                    txtCardnumber.Text = lvCard.Items[i].SubItems[2].Text.Trim();
                    cbPrivilege.Text = lvCard.Items[i].SubItems[3].Text.Trim();
                    txtPassword.Text = lvCard.Items[i].SubItems[4].Text.Trim();

                    sEnabled = lvCard.Items[i].SubItems[5].Text.Trim();
                    if (sEnabled == "true")
                    {
                        chbEnabled.Checked = true;
                    }
                    else
                    {
                        chbEnabled.Checked = false;
                    }
                    break;
                }
            }
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            if (bIsConnected)
            {
                txtLog.Text = "Random Gen:" + a.Next(100000, 199999) + "\n" + txtLog.Text;
                txtLog.Text = "Team 5: " + getPasscode(5) + "\n" + txtLog.Text;
                txtLog.Text = "Team 4: " + getPasscode(4) + "\n" + txtLog.Text;
                txtLog.Text = "Team 3: " + getPasscode(3) + "\n" + txtLog.Text;
                txtLog.Text = "Team 2: " + getPasscode(2) + "\n" + txtLog.Text;
                txtLog.Text = "Team 1: " + getPasscode(1) + "\n" + txtLog.Text;
                setPasscode(1);
                setPasscode(2);
                setPasscode(3);
                setPasscode(4);
                setPasscode(5);
                txtLog.Text = "Set Team 4, state: " + "\n" + txtLog.Text;
                txtLog.Text = "Time:    " + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt") + "   TimeStamp:" + UnixTimeNow() + "   Pass:" + (UnixTimeNow()-t).ToString() + "\n" + txtLog.Text;
                t = UnixTimeNow();
                txtLog.Refresh();
            }
           
        }

        public long UnixTimeNow()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            return (long)timeSpan.TotalSeconds;
        }

        private string getPasscode(int teamid)
        {
            string result = "123456";
            string connString = @"Data Source=" + this.datasource + ";Initial Catalog=" + this.database + ";Persist Security Info=True;User ID=" + this.username + ";Password=" + this.password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "SELECT passcode from UserLock where teamid = " + teamid;
                result = (String)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
            }
            return result;
        }

        private void setPasscode(int teamid)
        {
            string mypasscode = getPasscode(teamid);
            if (mypasscode==null) return;



            if (bIsConnected == false)
            {
                MessageBox.Show("Please connect the device first!", "Error");
                return;
            }

            int idwErrorCode = 0;
            //string sdwEnrollNumber = "";
            string sName = "";
            string sPassword = "";
            int iPrivilege;
            bool bEnabled = true;
            string sCardnumber = "";

            Cursor = Cursors.WaitCursor;
            axCZKEM1.EnableDevice(iMachineNumber, false);
            axCZKEM1.SSR_GetUserInfo(iMachineNumber, teamid.ToString(), out sName, out sPassword, out iPrivilege, out bEnabled);
            axCZKEM1.GetStrCardNumber(out sCardnumber);

            axCZKEM1.SetStrCardNumber(sCardnumber);//Before you using function SetUserInfo,set the card number to make sure you can upload it to the device
            if (axCZKEM1.SSR_SetUserInfo(iMachineNumber, teamid.ToString(), sName, mypasscode, iPrivilege, bEnabled))//upload the user's information(card number included)
            {
                //MessageBox.Show("(SSR_)SetUserInfo,UserID:" + sdwEnrollNumber + " pass:" + mypasscode + " Enabled:" + bEnabled.ToString(), "Success");
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                //MessageBox.Show("Operation failed,ErrorCode=" + idwErrorCode.ToString(), "Error");
            }
            axCZKEM1.RefreshData(iMachineNumber);//the data in the device should be refreshed
            axCZKEM1.EnableDevice(iMachineNumber, true);
            Cursor = Cursors.Default;

            return;
        }

        private string getPasscodeonTime(int teamid)
        {
            string result = "123456";
            string connString = @"Data Source=" + this.datasource + ";Initial Catalog=" + this.database + ";Persist Security Info=True;User ID=" + this.username + ";Password=" + this.password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            try
            {
                SqlCommand cmd = conn.CreateCommand();
                long tbegin = UnixTimeNow() - 300;
                long tend = UnixTimeNow() + 300;
                cmd.CommandText = "SELECT passcode from UserLock where finish not like 'pass' and teamid = " + teamid + " and checkin >" + tbegin + " or checkin <" + tend ;
                result = (String)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                conn.Close();
                //conn.Dispose();
            }
            return result;
        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}