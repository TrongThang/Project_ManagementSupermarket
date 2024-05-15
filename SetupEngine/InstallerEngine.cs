using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Data.SqlClient;
using System.Xml;
using System.Collections.Specialized;

namespace SetupEngine

{

    [RunInstaller(true)]

    public partial class InstallerEngine : System.Configuration.Install.Installer

    {

        private string logFilePath = "";

        private string pathApp = "";

        public InstallerEngine()

        {

            InitializeComponent();

        }

        private string GetSql(string Name)

        {

            try

            {

                // Gets the current assembly.

                Assembly Asm = Assembly.GetExecutingAssembly();

                // Resources are named using a fully qualified name.

                Stream strm = Asm.GetManifestResourceStream(Asm.GetName().Name + "." +Name);

                // Reads the contents of the embedded file.

                StreamReader reader = new StreamReader(strm);

                string sInfor = reader.ReadToEnd();

                Log(sInfor);

                reader.Close();

                return sInfor;

            }

            catch (Exception ex)

            {

                Log(ex.ToString());

                throw ex;

            }

        }

        private void ExecuteSql(string serverName, string dbName, string userid, string password, string Sql)

        {

            string connStr = "server =" +serverName + "; database =" +dbName + "; uid =" +userid + "; pwd =" +password;

            using (SqlConnection conn = new SqlConnection(connStr))

            {

                try

                {

                    SqlCommand cmd = new SqlCommand(Sql);

                    conn.Open();

                    cmd.Connection = conn;

                    int n = cmd.ExecuteNonQuery();

                    Log(" n = " +n);

                    conn.Close();

                }

                catch (Exception ex)

                {

                    Log(ex.ToString());

                }

            }

        }

        protected void AddDBTable(string serverName, string userid, string password)

        {

            try

            {

                // Creates the database and installs the tables.

                string strScript = GetSql("sqldropcreate.txt");

                ExecuteSql(serverName, "master", userid, password, strScript);

                System.Threading.Thread.Sleep(60 * 1000);

                strScript = GetSql("sqldata.txt");

                ExecuteSql(serverName, "QLST", userid, password, strScript);

                System.Threading.Thread.Sleep(60 * 1000);

                string connStr = "server =" +serverName + "; database = dbqlsv; uid =" +userid + "; pwd =" +password;

                Log("AppPath =" +pathApp);

                XmlDocument xmlDom = new XmlDocument();

                xmlDom.Load(pathApp);

                // Get XML node

                XmlNode xmlNode = xmlDom.SelectSingleNode("configuration / appSettings / add[@key ='MYCONN']");

                xmlNode.Attributes["value"].Value = connStr;

                // Updating connection string in file

                Log("Followind node of config file will be updated: " +xmlNode.InnerXml);

                // Save to disk

                xmlDom.Save(pathApp);

            }

            catch (Exception ex)

            {

                //Reports any errors and abort.

                Log(ex.ToString());

                throw ex;

            }

        }

        protected override void OnAfterInstall(IDictionary savedState)

        {

            base.OnAfterInstall(savedState);

        }

        public override void Install(System.Collections.IDictionary stateSaver)

        {

            base.Install(stateSaver);

            string assemPath = this.Context.Parameters["assemblypath"];

            int pos = assemPath.LastIndexOf("\\");

            logFilePath = assemPath.Substring(0, pos + 1) + "\\SetupLog117.txt";

            pathApp = assemPath.Substring(0, pos + 1) + "\\ManagementSupermarket.exe.config";

            Log("—-Setup started—-");

            Log("Server =" +this.Context.Parameters["servername"] + " ; User Id =" +this.Context.Parameters["userid"] + " ; pwd =" +this.Context.Parameters["password"]);

            foreach (DictionaryEntry s in this.Context.Parameters)

            {

                Log("Parameter: "+s.Key +" ; value ="+s.Value);

            }

            AddDBTable(this.Context.Parameters["servername"], this.Context.Parameters["userid"], this.Context.Parameters["password"]);

        }

        public void Log(string str)

        {

            StreamWriter Tex;

            try

            {

                Tex = File.AppendText(this.logFilePath);

                Tex.WriteLine(DateTime.Now.ToString() + " " +str);

                Tex.Close();

            }

            catch

            { }

        }

    }

}