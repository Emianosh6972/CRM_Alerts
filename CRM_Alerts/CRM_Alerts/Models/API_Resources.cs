namespace CRM_Alerts.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class API_Resources
    {
        public enum resource
        {
            clients,
            assets,
            licenses,
            credentials,
            asset_categories,
            license_categories,
            status_labels,
            manufacturers,
            models,
            locations,
            suppliers,
            projects,
            tickets,
            ticket_replies,
            issues,
            kb_categories,
            kb_articles,
            monitoring_hosts,
            monitoring_checks,
            users,
            staff,
            roles,
            languages,
            contacts,
            comments,
            milestones,
            predefined_replies,
            custom_asset_fields,
            custom_license_fields,
            config,
            ticket_departments,
            time_log,
            system_log,
            files,
            authenticate
        }
        public class clients
        {
            public int id { get; set; }
            public string name { get; set; }
            public string asset_tag_prefix { get; set; }
            public string license_tag_prefix { get; set; }
            public string notes { get; set; }
        }
        public class assets
        {
            public int id { get; set; }
            public int categoryid { get; set; }
            public int adminid { get; set; }
            public int clientid { get; set; }
            public int userid { get; set; }
            public int manufacturerid { get; set; }
            public int modelid { get; set; }
            public int supplierid { get; set; }
            public int statusid { get; set; }
            public DateTime purchase_date { get; set; }
            public int warranty_months { get; set; }
            public string tag { get; set; }
            public string name { get; set; }
            public string serial { get; set; }
            public string notes { get; set; }
            public int locationid { get; set; }
            public custom_asset_fields[] customfields { get; set; }
            public string qrvalue { get; set; }
        }
        public class licenses
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public int statusid { get; set; }
            public int categoryid { get; set; }
            public int supplierid { get; set; }
            public string seats { get; set; }
            public string tag { get; set; }
            public string name { get; set; }
            public string serial { get; set; }
            public string notes { get; set; }
            public custom_license_fields[] customfields { get; set; }
        }
        public class credentials
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public int assetid { get; set; }
            public string type { get; set; }
            public string username { get; set; }
            public string password { get; set; }
        }
        public class asset_categories
        {
            public int id { get; set; }
            public string name { get; set; }
            public string color { get; set; }
        }
        public class licence_categories
        {
            public int id { get; set; }
            public string name { get; set; }
            public string color { get; set; }
        }
        public class status_labels
        {
            public int id { get; set; }
            public string name { get; set; }
            public string color { get; set; }
        }
        public class manufacturers
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public class models
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public class locations
        {
            public int id { get; set; }
            public string name { get; set; }
            public int clientid { get; set; }
        }
        public class suppliers
        {
            public int id { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public string contactname { get; set; }
            public string phone { get; set; }
            public string email { get; set; }
            public string web { get; set; }
            public string notes { get; set; }
        }
        public class projects
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public string tag { get; set; }
            public string name { get; set; }
            public string notes { get; set; }
            public string description { get; set; }
            public DateTime startdate { get; set; }
            public DateTime deadline { get; set; }
            public int progress { get; set; }
        }
        public class tickets
        {
            public int id { get; set; }
            public int departmentid { get; set; }
            public int clientid { get; set; }
            public int adminid { get; set; }
            public int userid { get; set; }
            public int assetid { get; set; }
            public int projectid { get; set; }
            public string email { get; set; }
            public string subject { get; set; }
            public string priority { get; set; }            // Low Normal or High
            public string notes { get; set; }
            public string[] ccs { get; set; }
            public string message { get; set; }
            public Boolean notification { get; set; }
            public string status { get; set; }              // open, in progress, answered, reopened, closed
        }
        public class ticket_replies
        {
            public int id { get; set; }
            public int ticketid { get; set; }
            public int adminid { get; set; }
            public int userid { get; set; }
            public string message { get; set; }
            public int peopleid { get; set; }
            public string status { get; set; }              // open, in progress, answered, reopened or closed, optional to change the status of a ticket after adding the reply
            public Boolean notification { get; set; }
        }
        public class issues
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public int assetid { get; set; }
            public int projectid { get; set; }
            public int adminid { get; set; }
            public string issuetype { get; set; }       // task, maintenance, bug, improvement, new feature or story
            public string priority { get; set; }        // to do, in progress, in review or done
            public string name { get; set; }
            public string description { get; set; }
            public DateTime duedate { get; set; }
        }
        public class kb_categories
        {
            public int id { get; set; }
            public clients[] clients { get; set; }
            public string name { get; set; }
        }
        public class kb_articles
        {
            public int id { get; set; }
            public int categoryid { get; set; }
            public clients[] clients { get; set; }
            public string name { get; set; }
            public string content { get; set; }
        }
        public class monitoring_hosts
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public string name { get; set; }
            public string address { get; set; }
            public string status { get; set; }         // up, down, can be empty
        }
        public class monitoring_checks
        {
            public int id { get; set; }
            public int hostid { get; set; }
            public string name { get; set; }
            public string type { get; set; }
            public string port { get; set; }
            public Boolean monitoring { get; set; }
            public Boolean email { get; set; }
            public Boolean sms { get; set; }
            public string status { get; set; }          // up, down, empty
        }
        public class users
        {
            public int id { get; set; }
            public string name { get; set; }
            public int roleid { get; set; }
            public int clientid { get; set; }
            public string email { get; set; }
            public string ldap_user { get; set; }
            public int title { get; set; }
            public string mobile { get; set; }
            public string password { get; set; }
            public Boolean notification { get; set; }
            public string theme { get; set; }           // skin-blue,skin-black,skin-purple,skin-green,skin-red,skin-yellow,skin-blue-light,skin-black-light,skin-purple-light,skin-green-light,skin-red-light,skin-yellow-light
            public Boolean sidebar { get; set; }        // opened or collapsed
            public Boolean layout { get; set; }         // empty for standard, fixed or layout-boxed
            public string notes { get; set; }
            public string lang { get; set; }
            public string fcmtoken { get; set; }
        }
        public class staff
        {
            public int id { get; set; }
            public string name { get; set; }
            public int roleid { get; set; }
            public string email { get; set; }
            public string ldap_user { get; set; }
            public string title { get; set; }
            public string mobile { get; set; }
            public string password { get; set; }
            public Boolean notification { get; set; }
            public string theme { get; set; }           // skin-blue,skin-black,skin-purple,skin-green,skin-red,skin-yellow,skin-blue-light,skin-black-light,skin-purple-light,skin-green-light,skin-red-light,skin-yellow-light
            public Boolean sidebar { get; set; }
            public Boolean layout { get; set; }
            public string notes { get; set; }
            public string lang { get; set; }
            public int ticketsnotification { get; set; }
            public string fcmtoken { get; set; }
        }
        public class roles
        {
            public int id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string fcmtoken { get; set; }
            public [] perms { get; set; }
        }
        public class languages
        {
            public int id { get; set; }
            public string code { get; set; }
            public string name { get; set; }
        }
        public class contacts
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public string address { get; set; }
            public string webaddress { get; set; }
            public string notes { get; set; }
        }
        public class comments
        {
            public int id { get; set; }
            public int peopleid { get; set; }
            public int projectid { get; set; }
            public int ticketid { get; set; }
            public string comment { get; set; }
        }
        public class milestones
        {
            public int id { get; set; }
            public int projectid { get; set; }
            public string name { get; set; }
            public DateTime duedate { get; set; }
            public string description { get; set; }

        }
        public class predefined_replies
        {
            public int id { get; set; }
            public string name { get; set; }
            public string content { get; set; }
        }
        public class custom_asset_fields
        {
            public int id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string options { get; set; }
        }
        public class custom_license_fields
        {
            public int id { get; set; }
            public string type { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string options { get; set; }
        }
        public class ticket_departments
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
        }
        public class config
        {
            public string name { get; set; }
            public string value { get; set; }
        }
        public class time_log
        {
            public int id { get; set; }
            public int staffid { get; set; }
            public int clientid { get; set; }
            public int projectid { get; set; }
            public issues[] issues { get; set; }
            public tickets[] tickets { get; set; }
            public string description { get; set; }
            public DateTime date { get; set; }
            public DateTime start { get; set; }
            public DateTime end { get; set; }
        }
        public class system_log
        {
            public int id { get; set; }
            public int peopleid { get; set; }
            public string description { get; set; }
        }
        public class files
        {
            public int id { get; set; }
            public int clientid { get; set; }
            public int projectid { get; set; }
            public int assetid { get; set; }
            public int ticketreplyid { get; set; }
            public string name { get; set; }
            public files[] file { get; set; }
        }
        public class authenticate
        {
            public string username { get; set; }
            public string password { get; set; }
        }
    }
}