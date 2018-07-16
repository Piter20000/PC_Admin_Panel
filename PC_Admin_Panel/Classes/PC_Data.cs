using System;
using System.Net;
using System.Net.NetworkInformation;

namespace PC_Admin_Panel.Classes
{
    class PC_Data
    {
        #region Class Propeties 

        private string _ip;
        private string _windowsVersion;
        private string _is64BitOperationSystem;
        private string _PC_Name;
        private string _CPUS_Number;
        private string _logicalDrivesAvailable;
        private string _windowsFolder;
        private string _hostName;
        private string _domainName;
        private string  _query;

        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }
        public string Windows_Version
        {
            get { return _windowsVersion; }
            set { _windowsVersion = value; }
        }
        public string Is64BiteOS
        {
            get { return _is64BitOperationSystem; }
            set { _is64BitOperationSystem = value; }
        }
        public string PC_Name
        {
            get { return _PC_Name; }
            set { _PC_Name = value; }
        }
        public string CPUS_Number
        {
            get { return _CPUS_Number; }
            set { _CPUS_Number = value; }
        }
        public string LogicalDriversAvailable
        {
            get { return _logicalDrivesAvailable; }
            set { _logicalDrivesAvailable = value; }
        }
        public string WindowsFolder
        {
            get { return _windowsFolder; }
            set { _windowsFolder = value; }
        }
        public string HostName
        {
            get { return _hostName; }
            set { _hostName = value; }
        }
        public string DomainName
        {
            get { return _domainName; }
            set { _domainName = value; }
        }
        public string  Query
        {
            get { return _query; }
            set { _query = value; }
        }

        #endregion

        //   ###   Class constructors   ###   //

        /// <summary>
        /// Class constructor
        /// </summary>
        public PC_Data()
        {
            IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();

            // Copy IP adress
            string hostName = Dns.GetHostName();

            // Copy PC IP
            IP = Dns.GetHostByName(hostName).AddressList[0].ToString();

            // Copy Windows version
            Windows_Version = Environment.OSVersion.ToString();

            // Copy system version
            Is64BiteOS = Environment.Is64BitOperatingSystem ? "Yes" : "No";

            // Copy PC Name
            PC_Name = Environment.MachineName;

            // Copy number of CPUS
            CPUS_Number = Environment.ProcessorCount.ToString();

            // Copy Logical Drives Available
            LogicalDriversAvailable = String.Join(", ", Environment.GetLogicalDrives()).TrimEnd(',', ' ').Replace("\\", String.Empty);

            // Copy windows folder direction
            WindowsFolder = Environment.SystemDirectory;

            // Copy host name
            HostName = computerProperties.HostName;

            // Copy domain name
            DomainName = computerProperties.DomainName;

            // Generate Query
            Generate_Query();
        }

        //   ###   Methods   ###   //

        /// <summary>
        /// Method generate INSERT query 
        /// </summary>
        private void Generate_Query()
        {
            Query = $"INSERT INTO pc_data" +
                $"(admin_id," +
                $" ip," +
                $" windows_version," +
                $" 64BitOS," +
                $" pc_name," +
                $" cpus_number," +
                $" logical_drivers_available," +
                $" windows_folder," +
                $" host_name," +
                $" domain_name)" +
                $"VALUES" +
                $" ('{Session.Admin_Login}'," +
                $"'{IP}'," +
                $"'{Windows_Version}'," +
                $"'{Is64BiteOS}'," +
                $"'{PC_Name}'," +
                $"'{CPUS_Number}'," +
                $"'{LogicalDriversAvailable}'," +
                $"'{WindowsFolder}'," +
                $"'{HostName}'," +
                $"'{DomainName}')";
        }
    }
}
