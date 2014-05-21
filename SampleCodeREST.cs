using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Text;
using System.Windows.Forms;
using SampleCodeREST;


namespace SampleCode
{
    public partial class SampleCodeREST : Form
    {
        private string _IdentityToken = "PHNhbWw6QXNzZXJ0aW9uIE1ham9yVmVyc2lvbj0iMSIgTWlub3JWZXJzaW9uPSIxIiBBc3NlcnRpb25JRD0iXzQxNzlkZDA0LTMwMmMtNGI5Zi1iZmI1LTM3YjIzYzU2NmE5NyIgSXNzdWVyPSJJcGNBdXRoZW50aWNhdGlvbiIgSXNzdWVJbnN0YW50PSIyMDE0LTA1LTIwVDIyOjI2OjEyLjEwMVoiIHhtbG5zOnNhbWw9InVybjpvYXNpczpuYW1lczp0YzpTQU1MOjEuMDphc3NlcnRpb24iPjxzYW1sOkNvbmRpdGlvbnMgTm90QmVmb3JlPSIyMDE0LTA1LTIwVDIyOjI2OjEyLjEwMVoiIE5vdE9uT3JBZnRlcj0iMjAxNy0wNS0yMFQyMjoyNjoxMi4xMDFaIj48L3NhbWw6Q29uZGl0aW9ucz48c2FtbDpBZHZpY2U+PC9zYW1sOkFkdmljZT48c2FtbDpBdHRyaWJ1dGVTdGF0ZW1lbnQ+PHNhbWw6U3ViamVjdD48c2FtbDpOYW1lSWRlbnRpZmllcj5DRUFBODkyOUJGQjAwMDAxPC9zYW1sOk5hbWVJZGVudGlmaWVyPjwvc2FtbDpTdWJqZWN0PjxzYW1sOkF0dHJpYnV0ZSBBdHRyaWJ1dGVOYW1lPSJTQUsiIEF0dHJpYnV0ZU5hbWVzcGFjZT0iaHR0cDovL3NjaGVtYXMuaXBjb21tZXJjZS5jb20vSWRlbnRpdHkiPjxzYW1sOkF0dHJpYnV0ZVZhbHVlPkNFQUE4OTI5QkZCMDAwMDE8L3NhbWw6QXR0cmlidXRlVmFsdWU+PC9zYW1sOkF0dHJpYnV0ZT48c2FtbDpBdHRyaWJ1dGUgQXR0cmlidXRlTmFtZT0iU2VyaWFsIiBBdHRyaWJ1dGVOYW1lc3BhY2U9Imh0dHA6Ly9zY2hlbWFzLmlwY29tbWVyY2UuY29tL0lkZW50aXR5Ij48c2FtbDpBdHRyaWJ1dGVWYWx1ZT41YWE2NTBlMS1lNjQwLTRmYTYtOGU2NC1iM2QxNWU0Mzc0YzY8L3NhbWw6QXR0cmlidXRlVmFsdWU+PC9zYW1sOkF0dHJpYnV0ZT48c2FtbDpBdHRyaWJ1dGUgQXR0cmlidXRlTmFtZT0ibmFtZSIgQXR0cmlidXRlTmFtZXNwYWNlPSJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcyI+PHNhbWw6QXR0cmlidXRlVmFsdWU+Q0VBQTg5MjlCRkIwMDAwMTwvc2FtbDpBdHRyaWJ1dGVWYWx1ZT48L3NhbWw6QXR0cmlidXRlPjwvc2FtbDpBdHRyaWJ1dGVTdGF0ZW1lbnQ+PFNpZ25hdHVyZSB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnIyI+PFNpZ25lZEluZm8+PENhbm9uaWNhbGl6YXRpb25NZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzEwL3htbC1leGMtYzE0biMiPjwvQ2Fub25pY2FsaXphdGlvbk1ldGhvZD48U2lnbmF0dXJlTWV0aG9kIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnI3JzYS1zaGExIj48L1NpZ25hdHVyZU1ldGhvZD48UmVmZXJlbmNlIFVSST0iI180MTc5ZGQwNC0zMDJjLTRiOWYtYmZiNS0zN2IyM2M1NjZhOTciPjxUcmFuc2Zvcm1zPjxUcmFuc2Zvcm0gQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjZW52ZWxvcGVkLXNpZ25hdHVyZSI+PC9UcmFuc2Zvcm0+PFRyYW5zZm9ybSBBbGdvcml0aG09Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvMTAveG1sLWV4Yy1jMTRuIyI+PC9UcmFuc2Zvcm0+PC9UcmFuc2Zvcm1zPjxEaWdlc3RNZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwLzA5L3htbGRzaWcjc2hhMSI+PC9EaWdlc3RNZXRob2Q+PERpZ2VzdFZhbHVlPmFaTnBGdDJnWUtvcEFYckZhcVNUMTFWNk4rRT08L0RpZ2VzdFZhbHVlPjwvUmVmZXJlbmNlPjwvU2lnbmVkSW5mbz48U2lnbmF0dXJlVmFsdWU+d3NEaWRERU0vdDFJdHQ1eG96Z2ZpTG4vL0lCSVlOY0tiUVpjWElDU3FXQWFoaER3WWpQWnU1NzlwbUtLN2ZiTnVRUVEyOGxyTWxRUEI3aGVYTDlFWHZqVzVEdGdlbU9sSldOeG0xdkZ1RDVyOEpuK3o0UmhvYkhyZDIyK25lL1lWZVRHbTNicWt0aS9zKzdKeFg4MkxSazhCUkdPTG04K2NKMXRUaENDREtMUG82cjBzTUVmbzQ4aGtLSkRCRFo2WkdQTmU0bWZPeFV1Y3BENk5GbHAxQjR5VzAwNnAvc3pjRURwRWpBbWRuaUVoTkE3T1A0RlVGUmlsM0tiWGN3ekdmWW1pdUJ6dkN6UFVhbk5seUFSQVRZRmozeUlmRVpFL0hFcVBhNlhxU2U3VHM5bmFoSTU0K0JnMU40NExJSWI2UTlSQVM3ZjJsUklEbS8vVE5iTDh3PT08L1NpZ25hdHVyZVZhbHVlPjxLZXlJbmZvPjxvOlNlY3VyaXR5VG9rZW5SZWZlcmVuY2UgeG1sbnM6bz0iaHR0cDovL2RvY3Mub2FzaXMtb3Blbi5vcmcvd3NzLzIwMDQvMDEvb2FzaXMtMjAwNDAxLXdzcy13c3NlY3VyaXR5LXNlY2V4dC0xLjAueHNkIj48bzpLZXlJZGVudGlmaWVyIFZhbHVlVHlwZT0iaHR0cDovL2RvY3Mub2FzaXMtb3Blbi5vcmcvd3NzL29hc2lzLXdzcy1zb2FwLW1lc3NhZ2Utc2VjdXJpdHktMS4xI1RodW1icHJpbnRTSEExIj5IY2cvdDBCSE1hSFdWeGs4c3EvelF5NHpySmc9PC9vOktleUlkZW50aWZpZXI+PC9vOlNlY3VyaXR5VG9rZW5SZWZlcmVuY2U+PC9LZXlJbmZvPjwvU2lnbmF0dXJlPjwvc2FtbDpBc3NlcnRpb24+";
        //The following PTLS SocketId is used for Sandbox and Certification transactions. Once certified, the software company will 
        //receive a production PTLS SocketId. This value is intended to be compiled into the software application that was certified.
        private string _PTLSSocketId =
            @"MIIEwjCCA6qgAwIBAgIBEjANBgkqhkiG9w0BAQUFADCBsTE0MDIGA1UEAxMrSVAgUGF5bWVudHMgRnJhbWV3b3JrIENlcnRpZmljYXRlIEF1dGhvcml0eTELMAkGA1UEBhMCVVMxETAPBgNVBAgTCENvbG9yYWRvMQ8wDQYDVQQHEwZEZW52ZXIxGjAYBgNVBAoTEUlQIENvbW1lcmNlLCBJbmMuMSwwKgYJKoZIhvcNAQkBFh1hZG1pbkBpcHBheW1lbnRzZnJhbWV3b3JrLmNvbTAeFw0wNjEyMTUxNzQyNDVaFw0xNjEyMTIxNzQyNDVaMIHAMQswCQYDVQQGEwJVUzERMA8GA1UECBMIQ29sb3JhZG8xDzANBgNVBAcTBkRlbnZlcjEeMBwGA1UEChMVSVAgUGF5bWVudHMgRnJhbWV3b3JrMT0wOwYDVQQDEzRFcWJwR0crZi8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vL0E9MS4wLAYJKoZIhvcNAQkBFh9zdXBwb3J0QGlwcGF5bWVudHNmcmFtZXdvcmsuY29tMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQD7BTLqXah9t6g4W2pJUfFKxJj/R+c1Dt5MCMYGKeJCMvimAJOoFQx6Cg/OO12gSSipAy1eumAqClxxpR6QRqO3iv9HUoREq+xIvORxm5FMVLcOv/oV53JctN2fwU2xMLqnconD0+7LJYZ+JT4z3hY0mn+4SFQ3tB753nqc5ZRuqQIDAQABo4IBVjCCAVIwCQYDVR0TBAIwADAdBgNVHQ4EFgQUk7zYAajw24mLvtPv7KnMOzdsJuEwgeYGA1UdIwSB3jCB24AU3+ASnJQimuunAZqQDgNcnO2HuHShgbekgbQwgbExNDAyBgNVBAMTK0lQIFBheW1lbnRzIEZyYW1ld29yayBDZXJ0aWZpY2F0ZSBBdXRob3JpdHkxCzAJBgNVBAYTAlVTMREwDwYDVQQIEwhDb2xvcmFkbzEPMA0GA1UEBxMGRGVudmVyMRowGAYDVQQKExFJUCBDb21tZXJjZSwgSW5jLjEsMCoGCSqGSIb3DQEJARYdYWRtaW5AaXBwYXltZW50c2ZyYW1ld29yay5jb22CCQD/yDY5hYVsVzA9BglghkgBhvhCAQQEMBYuaHR0cHM6Ly93d3cuaXBwYXltZW50c2ZyYW1ld29yay5jb20vY2EtY3JsLnBlbTANBgkqhkiG9w0BAQUFAAOCAQEAFk/WbEleeGurR+FE4p2TiSYHMau+e2Tgi+L/oNgIDyvAatgosk0TdSndvtf9YKjCZEaDdvWmWyEMfirb5mtlNnbZz6hNpYoha4Y4ThrEcCsVhfHLLhGZZ1YaBD+ZzCQA7vtb0v5aQb25jX262yPVshO+62DPxnMiJevSGFUTjnNisVniX23NVouUwR3n12GO8wvzXF8IYb5yogaUcVzsTIxEFQXEo1PhQF7JavEnDksVnLoRf897HwBqcdSs0o2Fpc/GN1dgANkfIBfm8E9xpy7k1O4MuaDRqq5XR/4EomD8BWQepfJY0fg8zkCfkuPeGjKkDCitVd3bhjfLSgTvDg==";

        private string _svcInfo = @"https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo";
        private string _txn = @"https://api.cert.nabcommerce.com/REST/2.0.18/Txn";
        private string _tms = @"https://api.cert.nabcommerce.com/REST/2.0.18/DataServices/TMS";

        private string _SessionToken = "";
        private DateTime _dtSessionToken;

        //Save ServiceInformation obtails from calling getServiceInformation()
        private readonly XmlDocument currentServiceInformation = new XmlDocument();
        //Values required to process transactions
        private string _ApplicationProfileId = "";
        private string _WorkflowId = "";
        private string _ServiceId = "";
        private string _MerchantProfileId = "";
        private string _AvailableWorkflowIds = "";
        private response _LastResponse;
        private bool _blnResponseMessage;
        private IndustryTypeValues _industryTypeValues = new IndustryTypeValues("false", "OffPremises", "PINNotSupported", "KeyOnly", "Ecommerce", "Ecommerce", "Keyed");//Default to Ecommerce

        //Ref Json to XML : http://msdn.microsoft.com/en-us/library/bb299886.aspx
        // and http://www.json.org/
        //Format JSON Online : http://jsonformat.com/#jsondataurllabel

        public SampleCodeREST()
        {
            InitializeComponent();

            //Current webservice releases available.
            CboPTLSVersion.Items.Add(new item("1.17.18", "0"));
            CboPTLSVersion.SelectedIndex = 0;

            //Actions for Application Data - Typically only performed upon initial installation of software
            //Note : Resultant variable to be stored : ApplicationProfileId
            cboApplicationDataAction.Items.Add(new item("[Select Action]", "0"));
            cboApplicationDataAction.Items.Add(new item("Get Application Data", "1"));
            cboApplicationDataAction.Items.Add(new item("Save Application Data", "2"));
            cboApplicationDataAction.Items.Add(new item("Delete Application Data", "3"));
            cboApplicationDataAction.SelectedIndex = 0;

            //Actions for managing Merchant Data - Depenging on number of merchants may or may not be commonly used
            //Note : Resultant variable to be stored : MerchantProfileId
            cboMerchantProfileAction.Items.Add(new item("[Select Action]", "0"));
            cboMerchantProfileAction.Items.Add(new item("Get Merchant Profiles", "1"));
            cboMerchantProfileAction.Items.Add(new item("Get Merchant Profile", "2"));
            cboMerchantProfileAction.Items.Add(new item("Save Merchant Data", "3"));
            cboMerchantProfileAction.Items.Add(new item("Delete Merchant Data", "4"));
            cboMerchantProfileAction.SelectedIndex = 0;

            TxtLoadIdentityToken.Text = _IdentityToken;

            //Format the dateTimePicker for TMS queries
            dtpStartTimeTMS.Format = DateTimePickerFormat.Custom;
            dtpStartTimeTMS.CustomFormat = "dddd MM'/'dd'/'yyyy hh':'mm tt";
            dtpStartTimeTMS.Value = DateTime.Now.AddHours(-2);

            dtpEndTimeTMS.Format = DateTimePickerFormat.Custom;
            dtpEndTimeTMS.CustomFormat = "dddd MM'/'dd'/'yyyy hh':'mm tt";
            dtpEndTimeTMS.Value = DateTime.Now;
        }

        private void cmdPOST_Click(object sender, EventArgs e)
        {
            if (chkAlwaysCheckSessionToken.Checked)
                checkTokenExpire();
            if (txtReplaceInURL.Text.Length > 1)
                txtUrl.Text = txtUrl.Text.Replace(txtReplaceInURL.Text, txtReplaceInURLWith.Text);

            CreateRequest(txtUrl.Text, cboActionOrMethod.Text, txtRequest.Text, _SessionToken, "",
                          TransactionType.NotSet);
        }

        private void cmdSignOnWithToken_Click(object sender, EventArgs e)
        {
            SignOnWithToken();
        }

        public string RetrieveServiceKeyFromIdentityToken(string identityToken)
        {
            try
            {
                String clearToken = Encoding.UTF8.GetString(Convert.FromBase64String(identityToken));

                //Now try and retrieve the Service Key from the XML
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(clearToken);
                XPathNavigator xnav = doc.CreateNavigator();

                XmlNamespaceManager manager = new XmlNamespaceManager(xnav.NameTable);
                manager.AddNamespace("SK", "urn:oasis:names:tc:SAML:1.0:assertion");

                XPathNavigator node = xnav.SelectSingleNode("//SK:Attribute[@AttributeName='SAK']", manager);
                return node.Value;
            }
            catch (Exception ex)
            {
                return "SK : Unknown";
            }
        }

        private void cmdManageApplicationData_Click(object sender, EventArgs e)
        {
            checkTokenExpire();

            item item = (item)cboApplicationDataAction.SelectedItem;
            _ApplicationProfileId = txtApplicationProfileId.Text;
            if (item.Value == "0")
            {
                MessageBox.Show("Please select an action");
                return;
            }
            if (item.Value == "1")
            {
                //Get Application Data
                if (_ApplicationProfileId.Length < 1)
                {
                    MessageBox.Show("Please enter an ApplicationId");
                    return;
                }
                GetApplicationData();
                return;
            }
            if (item.Value == "2")
            {
                //Save Application Data
                SaveApplicationData();
                return;
            }
            if (item.Value == "3")
            {
                //Delete Application Data
                if (_ApplicationProfileId.Length < 1)
                {
                    MessageBox.Show("Please enter an ApplicationId");
                    return;
                }
                DeleteApplicationData();
                return;
            }
        }

        private string CreateRequest(string _url, string _method, string _body, string _UserName, string _UserPassword,
                                     TransactionType _transactionType)
        {
            //http://msdn.microsoft.com/en-us/library/bb969540(office.12).aspx
            //http://www.daniweb.com/forums/thread241233.html
            //http://stackoverflow.com/questions/897782/how-to-add-custom-http-header-for-c-web-service-client-consuming-axis-1-4-web-se

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
                request.Method = _method; //Valid values are "GET", "POST", "PUT" and "DELETE"
                request.UserAgent =
                    "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50215)";
                request.ContentType = "text/xml; charset=utf-8";
                request.Timeout = 1000 * 60;
                //Authorization is made up of UserName and Password in the format [UserName]:[Password]. In this case the identity token is the only value set and is the [UserName]
                String _Authorization = "Basic " +
                                        Convert.ToBase64String(Encoding.ASCII.GetBytes(_UserName + ":" + _UserPassword));
                request.Headers.Add(HttpRequestHeader.Authorization, _Authorization);

                //Capture the basical header information. Using a proxy sniffer would be prefered however this helps to capture most information.
                string ContentLength = "";
                if (request.ContentLength > 0)
                    ContentLength = "\r\nContent-Length: " + request.ContentLength;
                string _HeaderInformation = _method + " " + request.Address.AbsolutePath + request.Address.Query +
                                            "\r\n" + request.Headers.ToString().Trim() + "\r\nHost: " +
                                            request.Address.Host + ContentLength + "\r\n\r\n";

                if (_body.Length > 0)
                {
                    StreamWriter writer = new StreamWriter(request.GetRequestStream());
                    writer.Write(_body);
                    writer.Close();
                }
                txtRequest.Text = _HeaderInformation + _body;
                RTxtSummary.SelectionColor = Color.Blue;
                RTxtSummary.AppendText("REQUEST : \r\n");
                RTxtSummary.SelectionColor = Color.Black;
                RTxtSummary.AppendText(_HeaderInformation + _body + "\r\n");

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (Stream data = response.GetResponseStream())
                {
                    try
                    {
                        string text = new StreamReader(data).ReadToEnd();

                        //Log out request and response as well as process last response for follow-on messages.
                        //Diaplay in modal the request information? 
                        if (ChkShowRequestModal.Checked)
                        {
                            ModalInformation mI = new ModalInformation();
                            mI.CallingForm("**** REQUEST****\r\n" + _HeaderInformation + _body +
                                           "\r\n\r\n**** RESPONSE ****\r\n" + text);
                            //mI.CallingForm(_method + " " + request.Address.AbsolutePath + "\r\n" + request.Headers + "Host: " + request.Address.Host + "\r\n" + request.ContentLength + request.Expect + _body);
                            mI.ShowDialog(this);
                        }
                        else
                        {
                            //Confirm processing of last transaction
                            if (!_blnResponseMessage && TransactionType.NotSet != _transactionType)
                            {
                                MessageBox.Show("Successfully processed " + _transactionType +
                                                " transaction. For more information about request and response check the show modal checkbox");
                                _blnResponseMessage = true;
                            }
                        }

                        txtResponse.Text = text;
                        RTxtSummary.SelectionColor = Color.Blue;
                        RTxtSummary.AppendText("\r\nRESPONSE : \r\n");
                        RTxtSummary.SelectionColor = Color.Black;
                        RTxtSummary.AppendText(text + "\r\n\r\n");

                        if (_transactionType != TransactionType.NotSet)
                            _LastResponse = ProcessResponse(text, _transactionType);

                        return text;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        data.Close();
                    }
                }
            }
            catch (WebException ex2)
            {
                //Lets get the webException returned in the response
                using (Stream data2 = ex2.Response.GetResponseStream())
                {
                    try
                    {
                        string text = new StreamReader(data2).ReadToEnd();
                        txtResponse.Text = text;
                        RTxtSummary.SelectionColor = Color.Blue;
                        RTxtSummary.AppendText("\r\nRESPONSE : \r\n");
                        RTxtSummary.SelectionColor = Color.Black;
                        RTxtSummary.AppendText(text + "\r\n");

                        return text;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        data2.Close();
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        private string CreateRequest_Json(string _url, string _method, string _body, string _UserName, string _UserPassword,
                             TransactionType _transactionType)
        {
            //http://msdn.microsoft.com/en-us/library/bb969540(office.12).aspx
            //http://www.daniweb.com/forums/thread241233.html
            //http://stackoverflow.com/questions/897782/how-to-add-custom-http-header-for-c-web-service-client-consuming-axis-1-4-web-se

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);
                request.Method = _method; //Valid values are "GET", "POST", "PUT" and "DELETE"
                request.UserAgent =
                    "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50215)";
                request.ContentType = "application/json";
                request.Timeout = 1000 * 60;
                //Authorization is made up of UserName and Password in the format [UserName]:[Password]. In this case the identity token is the only value set and is the [UserName]
                String _Authorization = "Basic " +
                                        Convert.ToBase64String(Encoding.ASCII.GetBytes(_UserName + ":" + _UserPassword));
                request.Headers.Add(HttpRequestHeader.Authorization, _Authorization);

                //Capture the basical header information. Using a proxy sniffer would be prefered however this helps to capture most information.
                string ContentLength = "";
                if (request.ContentLength > 0)
                    ContentLength = "\r\nContent-Length: " + request.ContentLength;
                string _HeaderInformation = _method + " " + request.Address.AbsolutePath + request.Address.Query +
                                            "\r\n" + request.Headers.ToString().Trim() + "\r\nHost: " +
                                            request.Address.Host + ContentLength + "\r\n\r\n";

                if (_body.Length > 0)
                {
                    StreamWriter writer = new StreamWriter(request.GetRequestStream());
                    writer.Write(_body);
                    writer.Close();
                }
                txtRequest.Text = _HeaderInformation + _body;
                RTxtSummary.SelectionColor = Color.Blue;
                RTxtSummary.AppendText("REQUEST : \r\n");
                RTxtSummary.SelectionColor = Color.Black;
                RTxtSummary.AppendText(_HeaderInformation + _body + "\r\n");
                HttpWebResponse response = null;

                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (Exception e)
                {
                    if (_method != "DELETE")
                        throw (e);
                }
                using (Stream data = response.GetResponseStream())
                {
                    try
                    {
                        string text = new StreamReader(data).ReadToEnd();

                        //Log out request and response as well as process last response for follow-on messages.
                        //Diaplay in modal the request information? 
                        if (ChkShowRequestModal.Checked)
                        {
                            ModalInformation mI = new ModalInformation();
                            mI.CallingForm("**** REQUEST****\r\n" + _HeaderInformation + _body +
                                           "\r\n\r\n**** RESPONSE ****\r\n" + text);
                            //mI.CallingForm(_method + " " + request.Address.AbsolutePath + "\r\n" + request.Headers + "Host: " + request.Address.Host + "\r\n" + request.ContentLength + request.Expect + _body);
                            mI.ShowDialog(this);
                        }
                        else
                        {
                            //Confirm processing of last transaction
                            if (!_blnResponseMessage && TransactionType.NotSet != _transactionType)
                            {
                                MessageBox.Show("Successfully processed " + _transactionType +
                                                " transaction. For more information about request and response check the show modal checkbox");
                                _blnResponseMessage = true;
                            }
                        }
                        txtResponse.Text = text;

                        RTxtSummary.SelectionColor = Color.Blue;
                        RTxtSummary.AppendText("\r\nRESPONSE : \r\n");
                        RTxtSummary.SelectionColor = Color.Black;
                        RTxtSummary.AppendText(text + "\r\n");

                        if (_transactionType != TransactionType.NotSet)
                            _LastResponse = ProcessResponse_Json(text, _transactionType);

                        return text;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        data.Close();
                    }
                }
            }
            catch (System.Net.WebException ex2)
            {
                //Lets get the webException returned in the response
                using (Stream data2 = ex2.Response.GetResponseStream())
                {
                    try
                    {
                        string text = new StreamReader(data2).ReadToEnd();
                        txtResponse.Text = text;
                        RTxtSummary.SelectionColor = Color.Blue;
                        RTxtSummary.AppendText("\r\nRESPONSE : \r\n");
                        RTxtSummary.SelectionColor = Color.Black;
                        RTxtSummary.AppendText(text + "\r\n");

                        return text;
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        data2.Close();
                    }
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }

        }

        public void checkTokenExpire()
        {
            if (DateTime.UtcNow.Subtract(_dtSessionToken).TotalMinutes > 25)
            //Use 25 as the baseline for renewing session tokens
            {
                try
                {
                    _SessionToken = "";
                    string strResponse = "";

                    if (ChkUseJsonInstead.Checked)
                    {
                        strResponse = CreateRequest_Json(_svcInfo + @"/token", "GET", "", _IdentityToken.Trim(), "",
                                   TransactionType.NotSet);
                        _SessionToken = strResponse.Substring(1, strResponse.Length - 2);
                    }
                    else
                    {
                        strResponse = CreateRequest(_svcInfo + @"/token", "GET", "", _IdentityToken.Trim(), "",
                                                           TransactionType.NotSet);
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(strResponse);
                        _SessionToken = doc.FirstChild.InnerText;
                    }

                    _dtSessionToken = DateTime.UtcNow;

                    //At this point enable all steps
                    cmdManageApplicationData.Enabled = true;
                    cmdRetrieveServiceInformation.Enabled = true;
                    cmdPerformMerchantProfileAction.Enabled = true;
                    chkStep1.Checked = true;
                }
                catch (System.Net.WebException ex2)
                {
                    //Lets get the webException returned in the response
                    using (Stream data2 = ex2.Response.GetResponseStream())
                    {
                        try
                        {
                            string text = new StreamReader(data2).ReadToEnd();
                            MessageBox.Show(text);
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }
                        finally
                        {
                            data2.Close();
                        }
                    }
                    throw;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to Refresh a new Token\r\nError Message : " + ex.Message, "SignOn Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    throw;
                }
            }
        }

        private void cmdClearResponse_Click(object sender, EventArgs e)
        {
            txtResponse.Text = "";
        }

        private void cmdClearRequest_Click(object sender, EventArgs e)
        {
            txtRequest.Text = "";
        }

        private void cboServiceIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            item item = (item)cboServiceIds.SelectedItem;
            _ServiceId = item.Value;

            _WorkflowId = _ServiceId;

            //based on serviceId selected, populate the proper operation types supported
            //XmlNodeList nodes = doc.SelectNodes("ServiceInformation/BankcardServices/BankcardService");
            XmlNodeList nodes = currentServiceInformation.GetElementsByTagName("BankcardService");

            CboProcessString.Items.Clear();
            CboProcessString.Text = "";
            foreach (XmlNode node in nodes)
            {
                if (node["ServiceId"].InnerXml == _WorkflowId)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(node.OuterXml);
                    XmlNodeList nodes2 = doc.GetElementsByTagName("Operations");
                    if (nodes2[0].HasChildNodes)
                    {
                        foreach (XmlNode n in nodes2[0])
                        {
                            if (n.InnerText == "true" | n.InnerText == "Supported")
                            {
                                CboProcessString.Items.Add(new item(n.Name, n.Name));
                            }
                        }
                    }
                    //CboProcessString.Items.Add(new item(node["ServiceId"].InnerText, node["ServiceId"].InnerText));
                }
            }

            if (_WorkflowId.Length > 0)
                GetMerchantProfiles();
        }

        private void cboAvailableProfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            item item = (item)cboAvailableProfiles.SelectedItem;
            _MerchantProfileId = item.Value;
        }

        #region Service Information Processing

        private void SignOnWithToken()
        {
            TxtServiceKeyValue.Text = RetrieveServiceKeyFromIdentityToken(TxtLoadIdentityToken.Text);

            if (_IdentityToken == null)
            {
                MessageBox.Show("Identity token is missing from the text box to the right");
                return;
            }
            if (CboPTLSVersion.Text.Length < 1)
            {
                MessageBox.Show("Please select a PTLS version");
                return;
            }
            if (_IdentityToken.Length < 1)
            {
                MessageBox.Show("Identity token is missing from the text box to the right");
                return;
            }

            //Expire the current session token
            _dtSessionToken = new DateTime();

            checkTokenExpire();
            //DeleteMerchantProfileId("746055", "214DF00001");
        }

        private void GetApplicationData()
        {
            /*
             *URL https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo/appProfile/{applicationProfileId}
             * Action GET 
            */

            if (_ApplicationProfileId.Length < 1)
            {
                MessageBox.Show("An ApplicationProfileId is required before calling Get Application Data");
                return;
            }

            if (ChkUseJsonInstead.Checked)
            {
                CreateRequest_Json(_svcInfo + @"/appProfile/" + _ApplicationProfileId, "GET", "", _SessionToken, "",
                             TransactionType.NotSet);

            }
            else
            {
                CreateRequest(_svcInfo + @"/appProfile/" + _ApplicationProfileId, "GET", "", _SessionToken, "",
                          TransactionType.NotSet);
            }
        }

        private void SaveApplicationData()
        {
            /*
             *URL https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo/appProfile 
             * Action PUT 
            */
            try
            {
                checkTokenExpire(); //Always verify that a valid token exists

                if (ChkUseJsonInstead.Checked)
                {
                    string strApplicationData = @"{"
                                + "\"ApplicationAttended\":" + _industryTypeValues.ApplicationAttended + ","
                                + "\"ApplicationLocation\":\"" + _industryTypeValues.ApplicationLocation + "\","
                                + "\"ApplicationName\":\"TestApp\","
                                 + "\"HardwareType\":\"PC\","
                                + "\"PINCapability\":\"" + _industryTypeValues.PINCapability + "\","
                                + "\"PTLSSocketId\":\"" + _PTLSSocketId + "\","
                                + "\"ReadCapability\":\"" + _industryTypeValues.ReadCapability + "\","
                                + "\"SerialNumber\":208093707,"
                                + "\"SoftwareVersion\":1,"
                                + "\"SoftwareVersionDate\":\"2014-05-20T00:00:00\","
                        //+ "\"DeviceSerialNumber\":\"TestApp\","
                                + "\"EncryptionType\":\"MagneSafeV4V5Compatible\""//<!-- [Magensa : Valid Values 'IPADV1Compatible', 'MagneSafeV4V5Compatible', 'NotSet'] -->
                                + "}"
                        ;

                    string strResponse = CreateRequest_Json(_svcInfo + @"/appProfile", "PUT", strApplicationData, _SessionToken,
                                                       "", TransactionType.NotSet);

                    //ToDo: Temporary way to get teh applciationProfileId
                    _ApplicationProfileId = strResponse.Substring(strResponse.IndexOf("appProfile") + 11, strResponse.LastIndexOf("\"") - (strResponse.IndexOf("appProfile") + 11));

                }
                else
                {
                    string strApplicationData = @"<ApplicationData xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/ServiceInformation'>"
                                                + @"<ApplicationAttended>" + _industryTypeValues.ApplicationAttended + "</ApplicationAttended>"
                                                + @"<ApplicationLocation>" + _industryTypeValues.ApplicationLocation + "</ApplicationLocation>"
                                                + @"<ApplicationName>TestApp</ApplicationName>"
                                                + @"<DeveloperId>123</DeveloperId>"
                                                + @"<HardwareType>PC</HardwareType>"
                                                + @"<PINCapability>" + _industryTypeValues.PINCapability + "</PINCapability>"
                                                + @"<PTLSSocketId>" + _PTLSSocketId + "</PTLSSocketId>"
                                                + @"<ReadCapability>" + _industryTypeValues.ReadCapability + "</ReadCapability>"
                                                + @"<SerialNumber>208093707</SerialNumber>"
                                                + @"<SoftwareVersion>1.0</SoftwareVersion>"
                                                + @"<SoftwareVersionDate>2012-05-15T00:00:00</SoftwareVersionDate>"
                                                + @"<VendorId></VendorId>"
                                                + @"<EncryptionType>MagneSafeV4V5Compatible</EncryptionType>"//<!-- [Magensa : Valid Values 'IPADV1Compatible', 'MagneSafeV4V5Compatible', 'NotSet'] -->
                        //+ @"<DeviceSerialNumber>123</DeviceSerialNumber>"
                                                + @"</ApplicationData> "
                        ;

                    string strResponse = CreateRequest(_svcInfo + @"/appProfile", "PUT", strApplicationData, _SessionToken,
                                                       "", TransactionType.NotSet);

                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(strResponse);
                    XPathNavigator xnav = doc.CreateNavigator();
                    //http://shaunedonohue.blogspot.com/2007/03/selectsinglenode-with-default-namespace.html
                    XmlNamespaceManager nsm = new XmlNamespaceManager(doc.NameTable);
                    nsm.AddNamespace("Nsm", "http://schemas.ipcommerce.com/CWS/v2.0/ServiceInformation/Rest");
                    XPathNavigator node = xnav.SelectSingleNode(@"//Nsm:id", nsm);

                    if (node == null)
                    {
                        MessageBox.Show("Application Profile could not be retrieved");
                        return;
                    }

                    _ApplicationProfileId = node.Value;

                }
                chkStep2.Checked = true;
                txtApplicationProfileId.Text = _ApplicationProfileId;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void DeleteApplicationData()
        {
            /*URL https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo/appProfile/{applicationProfileId} 
             * Action DELETE 
            */
            checkTokenExpire(); //Always verify that a valid token exists

            if (_ApplicationProfileId.Length < 1)
            {
                MessageBox.Show("An ApplicationProfileId is required before deleting application data");
                return;
            }
            if (ChkUseJsonInstead.Checked)
            {
                CreateRequest_Json(_svcInfo + @"/appProfile/" + _ApplicationProfileId, "DELETE", "", _SessionToken, "",
                             TransactionType.NotSet);
            }
            else
            {
                CreateRequest(_svcInfo + @"/appProfile/" + _ApplicationProfileId, "DELETE", "", _SessionToken, "",
                          TransactionType.NotSet);
            }
        }

        private void cmdRetrieveServiceInformation_Click(object sender, EventArgs e)
        {
            GetServiceInformation();
        }

        private void GetServiceInformation()
        {
            try
            {
                checkTokenExpire(); //Always verify that a valid token exists

                //ToDo: Need to find a way to parse Json so that the XML approach doesn't have to be used to populate dropdowns
                #region TEMPORARY APPROACH

                //Reset the dropdown
                cboServiceIds.Items.Clear(); //Reset The Services Dropdown
                cboServiceIds.Text = "";

                cboAvailableProfiles.Items.Clear(); //Reset The Services Dropdown
                cboAvailableProfiles.Text = "";

                cboMerchantProfileAction.SelectedIndex = 0;

                string strResponse = CreateRequest(_svcInfo + @"/serviceInformation", "GET", "", _SessionToken, "", TransactionType.NotSet);

                currentServiceInformation.LoadXml(strResponse);

                //XmlNodeList nodes = doc.SelectNodes("ServiceInformation/BankcardServices/BankcardService");
                XmlNodeList nodes = currentServiceInformation.GetElementsByTagName("BankcardService");

                foreach (XmlNode node in nodes)
                {
                    cboServiceIds.Items.Add(new item("[" + node["ServiceId"].InnerText + "] " + node["ServiceName"].InnerXml, node["ServiceId"].InnerText));
                }

                //Pull all WorkflowId's
                //_AvailableWorkflowIds
                nodes = currentServiceInformation.GetElementsByTagName("Workflow");
                _AvailableWorkflowIds = "";
                foreach (XmlNode node in nodes)
                {//[A007400011] ReD TEST HOST - Vantiv - D806000001
                    _AvailableWorkflowIds += "[" + node["WorkflowId"].InnerText + "] " + node["Name"].InnerText + " - " + node["ServiceId"].InnerText + "\r\n";
                }

                #endregion TEMPORARY APPROACH
                if (ChkUseJsonInstead.Checked)
                {
                    CreateRequest_Json(_svcInfo + @"/serviceInformation", "GET", "", _SessionToken, "", TransactionType.NotSet);
                }

                chkStep3.Checked = true;
            }
            catch (System.Net.WebException ex2)
            {
                //Lets get the webException returned in the response
                using (Stream data2 = ex2.Response.GetResponseStream())
                {
                    try
                    {
                        string text = new StreamReader(data2).ReadToEnd();
                        MessageBox.Show(text);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        data2.Close();
                    }
                }
            }
            catch (Exception e)
            {
                txtResponse.Text = e.Message;
                RTxtSummary.SelectionColor = Color.Red;
                RTxtSummary.AppendText("ERROR : \r\n" + e.Message + "\r\n");
            }
        }

        private void cmdPerformMerchantProfileAction_Click(object sender, EventArgs e)
        {
            _WorkflowId = _ServiceId;
            item item = (item)cboMerchantProfileAction.SelectedItem;
            if (item.Value == "0")
            {
                MessageBox.Show("Please select an action");
                return;
            }
            if (item.Value == "1")
            {
                //Get Merchant Data
                if (_MerchantProfileId.Length < 1)
                {
                    MessageBox.Show("Please select a Merchant Profile");
                    return;
                }
                GetMerchantProfiles();
                return;
            }
            if (item.Value == "2")
            {
                //Get Merchant Data
                GetMerchantProfile();
                return;
            }
            if (item.Value == "3")
            {
                //Save Merchant Data
                if (cboAvailableProfiles.Text.Length < 1)
                {
                    MessageBox.Show("Please type into the dropdown a MerchantProfileId");
                    return;
                }

                if (_WorkflowId.Length < 1)
                {
                    MessageBox.Show("Plesae select a valid ServiceId");
                    return;
                }
                _MerchantProfileId = cboAvailableProfiles.Text;
                SaveMerchantProfile();

                //Reset the dropdown 
                GetServiceInformation();

                return;
            }
            if (item.Value == "4")
            {
                //Delete Merchant Data
                if (_MerchantProfileId.Length < 1)
                {
                    MessageBox.Show("Please select a Merchant Profile");
                    return;
                }
                if (_WorkflowId.Length < 1)
                {
                    MessageBox.Show("Please select a ServiceId");
                    return;
                }
                DeleteMerchantProfileId(_MerchantProfileId, _WorkflowId);

                //Reset the dropdown 
                GetServiceInformation();

                return;
            }
        }

        private void GetMerchantProfile()
        {
            /*
             *URL https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo/merchProfile/{merchantProfileId}?serviceId={serviceId} 
             * Action GET 
            */

            try
            {
                checkTokenExpire(); //Always verify that a valid token exists

                if (_MerchantProfileId.Length < 1)
                {
                    MessageBox.Show("A MerchantProfileId is required before calling Get Merchant Profile");
                    return;
                }

                if (ChkUseJsonInstead.Checked)
                {
                    CreateRequest_Json(_svcInfo + @"/merchProfile/" + _MerchantProfileId + "?serviceId=" + _WorkflowId, "GET", "",
                    _SessionToken, "", TransactionType.NotSet);
                }
                else
                {
                    CreateRequest(_svcInfo + @"/merchProfile/" + _MerchantProfileId + "?serviceId=" + _WorkflowId, "GET", "",
                    _SessionToken, "", TransactionType.NotSet);
                }
            }
            catch (System.Net.WebException ex2)
            {
                //Lets get the webException returned in the response
                using (Stream data2 = ex2.Response.GetResponseStream())
                {
                    try
                    {
                        string text = new StreamReader(data2).ReadToEnd();
                        MessageBox.Show(text);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        data2.Close();
                    }
                }
            }
            catch (Exception e)
            {
                txtResponse.Text = e.Message;
                RTxtSummary.SelectionColor = Color.Red;
                RTxtSummary.AppendText("ERROR : \r\n" + e.Message + "\r\n");
            }

        }

        private void GetMerchantProfiles()
        {
            /*
             *URL To return all Merchant Profiles by serviceId:
              https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo/merchProfile?serviceId={serviceId}

              To return all Merchant Profiles by merchantProfileId (across multiple services):

              https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo/merchProfile?merchantProfileId={merchantProfileId} 
              Action GET  
             */

            try
            {
                checkTokenExpire(); //Always verify that a valid token exists

                //Reset the dropdown
                cboAvailableProfiles.Items.Clear(); //Reset The Services Dropdown
                cboAvailableProfiles.Text = "";

                if (_WorkflowId.Length < 1)
                {
                    MessageBox.Show("A ServiceId is required before calling GetMerchantProfiles");
                    return;
                }

                string strResponse = "";

                //else - Moved up from  the if statement below
                //ToDo : until I we can figure out how to convert JSon to an Object, using the older XML approach to populate the dropdowns. 
                //{
                strResponse = CreateRequest(_svcInfo + @"/merchProfile?serviceId=" + _WorkflowId, "GET", "", _SessionToken, "", TransactionType.NotSet);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(strResponse);

                //XmlNodeList nodes = doc.SelectNodes("ServiceInformation/BankcardServices/BankcardService");
                XmlNodeList nodes = doc.GetElementsByTagName("MerchantProfileId");

                foreach (XmlNode node in nodes)
                {
                    cboAvailableProfiles.Items.Add(new item(node["id"].InnerXml, node["id"].InnerText));
                }
                //}

                if (ChkUseJsonInstead.Checked)
                {
                    CreateRequest_Json(_svcInfo + @"/merchProfile?serviceId=" + _WorkflowId, "GET", "", _SessionToken, "", TransactionType.NotSet);
                }


                chkStep3.Checked = true;
            }
            catch (System.Net.WebException ex2)
            {
                //Lets get the webException returned in the response
                using (Stream data2 = ex2.Response.GetResponseStream())
                {
                    try
                    {
                        string text = new StreamReader(data2).ReadToEnd();
                        MessageBox.Show(text);
                    }
                    catch (Exception e)
                    {
                        throw e;
                    }
                    finally
                    {
                        data2.Close();
                    }
                }
            }
            catch (Exception e)
            {
                txtResponse.Text = e.Message;
                RTxtSummary.SelectionColor = Color.Red;
                RTxtSummary.AppendText("ERROR : \r\n" + e.Message + "\r\n");
            }

        }

        private void SaveMerchantProfile()
        {
            /*
             * URL https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo/merchProfile?serviceId={serviceId} 
             * Action PUT 
             */
            checkTokenExpire();//Always verify that a valid token exists

            if (ChkUseJsonInstead.Checked)
            {
                string strMerchantProfile = ""
                + "[{\"ProfileId\":\"" + _MerchantProfileId + "\","
                    + "\"WorkflowId\":\"" + _WorkflowId + "\","
                    //+ "\"ServiceName\":\"BCP Certification Service 10\","
                    //+ "\"LastUpdated\":\"" + DateTime.Now + "\","
                    + "\"MerchantData\":"
                    + "{"
                        + "\"CustomerServiceInternet\":\"\","
                        + "\"CustomerServicePhone\":\"720 3773700\","
                        + "\"Language\":\"ENG\","
                        + "\"Address\":"
                        + "{"
                            + "\"Street1\":\"777 Cherry Street\","
                            + "\"Street2\":\"\","
                            + "\"City\":\"Denver\","
                            + "\"StateProvince\":7,"
                            + "\"PostalCode\":\"80202\","
                            + "\"CountryCode\":\"USA\""
                        + "},"
                        + "\"MerchantId\":\"123456789012\","
                        + "\"Name\":\"TestMerchant\","
                        + "\"Phone\":\"720 3773700\","
                        + "\"TaxId\":\"\","
                        + "\"BankcardMerchantData\":"
                        + "{"
                            + "\"ABANumber\":\"1234\","
                            + "\"AcquirerBIN\":\"123456\","
                            + "\"AgentBank\":\"123456\","
                            + "\"AgentChain\":\"1234\","
                            + "\"Aggregator\":false,"
                            + "\"ClientNumber\":\"1224\","
                            + "\"IndustryType\":\"Ecommerce\","
                            + "\"Location\":\"123\","
                            + "\"MerchantType\":\"\","
                            + "\"PrintCustomerServicePhone\":false,"
                            + "\"QualificationCodes\":\"\","
                            + "\"ReimbursementAttribute\":\"1\","
                            + "\"SIC\":\"5734\","
                            + "\"SecondaryTerminalId\":\"12345678\","
                            + "\"SettlementAgent\":\"1234\","
                            + "\"SharingGroup\":\"1234\","
                            + "\"StoreId\":\"1234\","
                            + "\"TerminalId\":\"123\","
                            + "\"TimeZoneDifferential\":\"123\""
                        + "},"
                        + "\"ElectronicCheckingMerchantData\":"
                        + "{"
                            + "\"OrginatorId\":\"\","
                            + "\"ProductId\":\"\","
                            + "\"SiteId\":\"\""
                        + "}"
                    + "},"
                    + "\"TransactionData\":"
                    + "{"
                    + "\"BankcardTransactionDataDefaults\":"
                    + "{"
                        + "\"CurrencyCode\":\"USD\","
                        + "\"CustomerPresent\":\"Ecommerce\","
                        + "\"EntryMode\":\"Keyed\","
                        + "\"RequestACI\":\"IsCPSMeritCapable\","
                        + "\"RequestAdvice\":\"NotCapable\""
                    + "}"
                + "}"
            + "}]"
            ;

                CreateRequest_Json(_svcInfo + @"/merchProfile?serviceId=" + _WorkflowId, "PUT", strMerchantProfile, _SessionToken,
                              "", TransactionType.NotSet);
            }
            else
            {
                string strMerchantProfile =
                "<ArrayOfMerchantProfile xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/ServiceInformation'>"
                + "<MerchantProfile>"
                    + "<ProfileId>" + _MerchantProfileId + "</ProfileId>"
                    + " <WorkflowId>" + _WorkflowId + "</WorkflowId>"
                    //+ "<ServiceName i:nil='true'/>"//NOTE : Not used by Chase Orbital
                    + "<LastUpdated>0001-01-01T00:00:00</LastUpdated>"
                    + "<MerchantData>"
                    //+ "<CustomerServiceInternet>payanywherecommerce.com</CustomerServiceInternet>"
                        + "<CustomerServicePhone>720 3773700</CustomerServicePhone>"
                        + "<Language>ENG</Language>"
                        + "<Address>"
                            + "<Street1>1400 16th Street</Street1>"
                            + "<Street2 i:nil='true'/>"
                            + "<City>Denver</City>"
                            + "<StateProvince>CO</StateProvince>"
                            + "<PostalCode>80202</PostalCode>"
                            + "<CountryCode>USA</CountryCode>"
                        + "</Address>"
                        + "<MerchantId>123456789012</MerchantId>"
                        + "<Name>TestMerchant</Name>"
                        + "<Phone>720 3773700</Phone>"
                        + "<TaxId i:nil='true'/>"
                        + "<BankcardMerchantData>"
                            + "<ABANumber />" //NOTE : Not used by Chase Orbital
                            + "<AcquirerBIN/>" //NOTE : Not used by Chase Orbital
                            + "<AgentBank/>" //NOTE : Not used by Chase Orbital
                            + "<AgentChain>6452</AgentChain>" //NOTE : Not used by Chase Orbital
                            + "<ClientNumber>123</ClientNumber>" //NOTE : Not used by Chase Orbital
                            + "<IndustryType>Ecommerce</IndustryType>"
                            + "<Location/>" //NOTE : Not used by Chase Orbital
                            + "<MerchantType i:nil='true'/>" //NOTE : Not used by Chase Orbital
                            + "<PrintCustomerServicePhone>false</PrintCustomerServicePhone>"
                            + "<QualificationCodes i:nil='true'/>" //NOTE : Not used by Chase Orbital
                            + "<ReimbursementAttribute/>" //NOTE : Not used by Chase Orbital
                            + "<SIC>5734</SIC>"
                            + "<SecondaryTerminalId/>" //NOTE : Not used by Chase Orbital
                            + "<SettlementAgent />" //NOTE : Not used by Chase Orbital
                            + "<SharingGroup />" //NOTE : Not used by Chase Orbital
                            + "<StoreId>1234</StoreId>" //NOTE : Not used by Chase Orbital
                            + "<TerminalId>001</TerminalId>"
                            + "<TimeZoneDifferential/>" //NOTE : Not used by Chase Orbital
                        + "</BankcardMerchantData>"
                    + "</MerchantData>"
                    + "<TransactionData>"
                        + "<BankcardTransactionDataDefaults>"
                            + "<CurrencyCode>USD</CurrencyCode>"
                            + "<CustomerPresent>Ecommerce</CustomerPresent>"
                            + "<RequestACI>IsCPSMeritCapable</RequestACI>"
                            + "<RequestAdvice>NotCapable</RequestAdvice>"
                        + "</BankcardTransactionDataDefaults>"
                    + "</TransactionData>"
                + "</MerchantProfile>"
                + "</ArrayOfMerchantProfile>"
                ;

                CreateRequest(_svcInfo + @"/merchProfile?serviceId=" + _WorkflowId, "PUT", strMerchantProfile, _SessionToken,
                              "", TransactionType.NotSet);
            }
        }

        private void DeleteMerchantProfileId(string _MerchantProfileId, string _ServiceId)
        {
            /*
             * URL https://api.cert.nabcommerce.com/REST/x.xx.xx/SvcInfo/merchProfile/{merchantProfileId}?serviceId={serviceId} 
             * Action DELETE 
            */
            checkTokenExpire();//Always verify that a valid token exists

            if (ChkUseJsonInstead.Checked)
            {
                CreateRequest_Json(_svcInfo + @"/merchProfile/" + _MerchantProfileId + "?serviceId=" + _ServiceId, "DELETE", "",
               _SessionToken, "", TransactionType.NotSet);
            }
            else
            {
                CreateRequest(_svcInfo + @"/merchProfile/" + _MerchantProfileId + "?serviceId=" + _ServiceId, "DELETE", "",
               _SessionToken, "", TransactionType.NotSet);
            }
        }

        private void GetConfigurationValues()
        {
            string values = "";
            values = values + "ApplicationProfileId : " + _ApplicationProfileId + "\r\n";
            values = values + "ServiceId : " + _WorkflowId + "\r\n";
            values = values + "MerchantProfileId : " + _MerchantProfileId + "\r\n";
            values = values + "Available WorkflowId(s) : " + _AvailableWorkflowIds + "\r\n";
            TxtConfigurationValues.Text = values;
        }

        #endregion Service Information Processing

        #region Transaction Processing

        private void CmdProcess_Click(object sender, EventArgs e)
        {
            item item = (item)CboProcessString.SelectedItem;

            string operationType = item.Value;

            checkTokenExpire(); //Always verify that a valid token exists
            if (_ApplicationProfileId.Length < 1 | _WorkflowId.Length < 1 | _MerchantProfileId.Length < 1)
            {
                string strMessage = "";
                if (_ApplicationProfileId.Length < 1)
                    strMessage = strMessage + "A ApplicationProfileId must be selected\r\n";
                if (_WorkflowId.Length < 1)
                    strMessage = strMessage + "A ServiceId must be selected\r\n";
                if (_MerchantProfileId.Length < 1)
                    strMessage = strMessage + "A MerchantProfileId must be selected\r\n";
                MessageBox.Show(strMessage);
                return;
            }

            _WorkflowId = (TxtAltWorkFlowId.Text.Length > 0) ? TxtAltWorkFlowId.Text : _ServiceId;

            try
            {
                if (operationType == "AuthAndCapture")
                {
                    AuthorizeAndCapture();
                    return;
                }
                if (operationType == "Authorize")
                {
                    Authorize();
                    return;
                }
                if (operationType == "Verify")
                {
                    Verify();
                    return;
                }
                if (operationType == "QueryAccount")
                {
                    MessageBox.Show("Code needed for QueryAccount");
                    return;
                }
                if (operationType == "Adjust")
                {
                    Adjust();
                    return;
                }
                if (operationType == "ReturnById")
                {
                    ReturnById();
                    return;
                }
                if (operationType == "ReturnUnlinked")
                {
                    ReturnUnlinked();
                    return;
                }
                if (operationType == "Undo")
                {
                    Undo();
                    return;
                }
                if (operationType == "Capture")
                {
                    Capture();
                    return;
                }
                if (operationType == "CaptureSelective")
                {
                    CaptureSelective();
                    return;
                }
                if (operationType == "CaptureAll")
                {
                    //MessageBox.Show("Code needed for CaptureAll");
                    CaptureAll();
                    return;
                }
                if (operationType == "CloseBatch")
                {
                    MessageBox.Show("Code needed for CloseBatch");
                    return;
                }
                if (operationType == "QueryRejected")
                {
                    MessageBox.Show("Code needed for QueryRejected");
                    return;
                }
            }
            catch (System.Net.WebException ex2)
            {
                //Lets get the webException returned in the response
                using (Stream data2 = ex2.Response.GetResponseStream())
                {
                    try
                    {
                        string text = new StreamReader(data2).ReadToEnd();
                        MessageBox.Show(text);
                    }
                    catch (Exception es)
                    {
                        throw es;
                    }
                    finally
                    {
                        data2.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                txtResponse.Text = ex.Message;
                RTxtSummary.SelectionColor = Color.Red;
                RTxtSummary.AppendText("ERROR : \r\n" + ex.Message + "\r\n");
            }
        }

        private void AuthorizeAndCapture()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strAuthorizeAndCaptureRequest =
                    "{\"$type\":\"AuthorizeAndCaptureTransaction,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                    + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                    + "\"MerchantProfileId\":\"" + _MerchantProfileId + "\","
                    + buildTransaction_Json()
                    + "}"
                    ;

                CreateRequest_Json(_txn + @"/" + _WorkflowId, "POST", strAuthorizeAndCaptureRequest, _SessionToken, "",
                              TransactionType.AuthorizeAndCapture);
            }
            else
            {
                string strAuthorizeAndCaptureRequest =
                    "<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='AuthorizeAndCaptureTransaction' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                    + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                    + "<MerchantProfileId>" + _MerchantProfileId + "</MerchantProfileId>"
                    + buildTransaction()
                    + "</SubmitTransaction>"
                    ;

                CreateRequest(_txn + @"/" + _WorkflowId, "POST", strAuthorizeAndCaptureRequest, _SessionToken, "",
                          TransactionType.AuthorizeAndCapture);
            }
        }

        private void Authorize()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strAuthorizeAndCaptureRequest =
                    "{\"$type\":\"AuthorizeTransaction,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                    + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                    + "\"MerchantProfileId\":\"" + _MerchantProfileId + "\","
                    + buildTransaction_Json()
                    + "}"
                    ;

                CreateRequest_Json(_txn + @"/" + _WorkflowId, "POST", strAuthorizeAndCaptureRequest, _SessionToken, "",
                          TransactionType.Authorize);
            }
            else
            {
                string strAuthorizeAndCaptureRequest =
                    "<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='AuthorizeTransaction' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                   + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                   + "<MerchantProfileId>" + _MerchantProfileId + "</MerchantProfileId>"
                   + buildTransaction()
                   + "</SubmitTransaction>"
                    ;

                CreateRequest(_txn + @"/" + _WorkflowId, "POST", strAuthorizeAndCaptureRequest, _SessionToken, "",
                              TransactionType.Authorize);
            }
        }

        private void Adjust()
        {
            if (_LastResponse != null && _LastResponse.TransactionType == TransactionType.AuthorizeAndCapture)
            {
                if (ChkUseJsonInstead.Checked)
                {
                    string strAuthorizeAndCaptureId =
                        "{\"$type\":\"Adjust,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                            + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                            + "\"DifferenceData\":"
                            + "{"
                                + "\"TransactionId\":\"" + _LastResponse.TransactionId + "\","
                                + "\"TipAmount\":\"2.00\","
                                + "\"Amount\":\"2.00\","
                                + "\"Addendum\":null"
                            + "}"
                        + "}";

                    CreateRequest_Json(_txn + @"/" + _WorkflowId + @"/" + _LastResponse.TransactionId, "PUT", strAuthorizeAndCaptureId, _SessionToken, "",
                                  TransactionType.Adjust);
                }
                else
                {
                    string strAuthorizeAndCaptureId = "<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='Adjust' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                            + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                              + "<DifferenceData xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions'>"
                                + "<d2p1:Amount>2.00</d2p1:Amount>"
                                + "<d2p1:TransactionId>" + _LastResponse.TransactionId + "</d2p1:TransactionId>"
                                + "<d2p1:TipAmount>2.00</d2p1:TipAmount>"
                            + "</DifferenceData>"
                            + "</SubmitTransaction>"
                            ;
                    CreateRequest(_txn + @"/" + _WorkflowId + @"/" + _LastResponse.TransactionId, "PUT", strAuthorizeAndCaptureId, _SessionToken, "",
                                  TransactionType.Adjust);
                }
                _LastResponse = null; //clear out the last transaction as no more operations to process

            }
            else
            {
                MessageBox.Show("In order to process an Adjust a AuthorizeAndCapture needs to be processed first");
            }
        }

        private void Capture()
        {
            if (_LastResponse != null && _LastResponse.TransactionType == TransactionType.Authorize)
            {
                if (ChkUseJsonInstead.Checked)
                {
                    string strCapture = "{\"$type\":\"Capture,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                            + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                            + "\"DifferenceData\":"
                            + "{"
                                + "\"$type\":\"BankcardCapture,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard\","
                                + "\"Amount\":\"" + TxtAmount.Text + "\","
                                + "\"TransactionId\":\"" + _LastResponse.TransactionId + "\","
                                + "\"TipAmount\":\"0.00\","
                                + "\"Addendum\":null"
                            + "}"
                        + "}"
                        ;
                    CreateRequest_Json(_txn + @"/" + _WorkflowId + @"/" + _LastResponse.TransactionId, "PUT", strCapture, _SessionToken, "", TransactionType.Capture);
                }
                else
                {
                    string strCapture =
                        "<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='Capture' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                        + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                        +
                        "<DifferenceData xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions' xmlns:d2p2='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard' i:type='d2p2:BankcardCapture'>"
                        + "<d2p1:Amount>" + TxtAmount.Text + "</d2p1:Amount>"
                        + "<d2p1:TransactionId>" + _LastResponse.TransactionId + "</d2p1:TransactionId>"
                        + "<d2p1:TipAmount>0.00</d2p1:TipAmount>"
                        + "</DifferenceData>"
                        + "</SubmitTransaction>"
                        ;

                    CreateRequest(_txn + @"/" + _WorkflowId + @"/" + _LastResponse.TransactionId, "PUT", strCapture, _SessionToken, "", TransactionType.Capture);
                }
            }
            else
            {
                MessageBox.Show("In order to process a Capture an Authorize transction needs to be processed first");
            }
        }

        private void CaptureAll()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strCapture = "{\"$type\":\"CaptureAll,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                        + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                        + "\"MerchantProfileId\":\"" + _MerchantProfileId + "\","
                    //+ "\"DifferenceData\":"
                    //+ "{"
                    //    + "\"$type\":\"BankcardCapture,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard\","
                    //    + "\"Amount\":\"" + TxtAmount.Text + "\","
                    //    + "\"TransactionId\":\"" + _LastResponse.TransactionId + "\","
                    //    + "\"TipAmount\":\"0.00\","
                    //    + "\"Addendum\":null"
                    //+ "}"
                    + "}"
                    ;
                CreateRequest_Json(_txn + @"/" + _WorkflowId, "PUT", strCapture, _SessionToken, "", TransactionType.CaptureAll);
            }
            else
            {
                string strCapture =
                    "<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='CaptureAll' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                    + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                    + "<MerchantProfileId>" + _MerchantProfileId + "</MerchantProfileId>"
                    //+ "<DifferenceData xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions' xmlns:d2p2='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard' i:type='d2p2:BankcardCaptureAll'>"
                    //+ "<d2p1:Amount>" + TxtAmount.Text + "</d2p1:Amount>"
                    //+ "<d2p1:TransactionId>" + _LastResponse.TransactionId + "</d2p1:TransactionId>"
                    //+ "<d2p1:TipAmount>0.00</d2p1:TipAmount>"
                    //+ "</DifferenceData>"
                    + "</SubmitTransaction>"
                    ;

                CreateRequest(_txn + @"/" + _WorkflowId, "PUT", strCapture, _SessionToken, "", TransactionType.CaptureAll);
            }
        }

        private void CaptureSelective()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strCapture = "{\"$type\":\"CaptureSelective,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                        + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                        + "\"DifferenceData\":"
                        + "[{"
                            + "\"$type\":\"BankcardCapturePro,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard/Pro\","
                            + "\"Amount\":\"" + TxtAmount.Text + "\","
                            + "\"TransactionId\":\"" + _LastResponse.TransactionId + "\""
                    //+ "\"TipAmount\":\"0.00\","
                    //+ "\"Addendum\":null"
                        + "}], "
                        + "\"TransactionIds\":"
                        + "[\"" + _LastResponse.TransactionId + "\""
                        + "]"
                    + "}"
                    ;
                CreateRequest_Json(_txn + @"/" + _WorkflowId, "PUT", strCapture, _SessionToken, "", TransactionType.CaptureSelective);
            }
            else
            {
                string strCapture =
                    "<CaptureTransactions xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest' xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='CaptureSelective'>"
                        + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                        + "<DifferenceData xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions'>"
                            + "<d2p1:Capture xmlns:d2p2='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard' xmlns:d2p3='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard/Pro' i:type='d2p3:BankcardCapturePro'>"
                                + "<d2p1:TransactionId>" + _LastResponse.TransactionId + "</d2p1:TransactionId>"
                                + "<d2p2:Amount>" + TxtAmount.Text + "</d2p2:Amount>"
                                + "<d2p2:ChargeType>RetailOther</d2p2:ChargeType>"
                            + "</d2p1:Capture>"
                        + "</DifferenceData>"
                        + "<TransactionIds xmlns:a='http://schemas.microsoft.com/2003/10/Serialization/Arrays'>"
                            + "<a:string>" + _LastResponse.TransactionId + "</a:string>"
                        + "</TransactionIds>"
                    + "</CaptureTransactions>"
                    ;

                CreateRequest(_txn + @"/" + _WorkflowId, "PUT", strCapture, _SessionToken, "", TransactionType.CaptureSelective);
            }
        }

        private void ReturnById()
        {
            if (_LastResponse != null &&
                (_LastResponse.TransactionType == TransactionType.AuthorizeAndCapture |
                 _LastResponse.TransactionType == TransactionType.Capture |
                 _LastResponse.TransactionType == TransactionType.Authorize))
            {
                if (ChkUseJsonInstead.Checked)
                {
                    string strReturnById =
                        "{\"$type\":\"ReturnById,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                            + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                            + "\"MerchantProfileId\":\"" + _MerchantProfileId + "\","
                            + "\"DifferenceData\":"
                            + "{\"$type\":\"BankcardReturn,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard\","
                                + "\"TransactionId\":\"" + _LastResponse.TransactionId + "\","
                                + "\"Amount\":\"" + TxtAmount.Text + "\","
                                + "\"Addendum\":null"
                            + "}"
                        + "}";

                    CreateRequest_Json(_txn + @"/" + _WorkflowId, "POST", strReturnById, _SessionToken, "",
                                  TransactionType.ReturnById);
                }
                else
                {
                    string strReturnById = "<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='ReturnById' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                            + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                            + "<MerchantProfileId>" + _MerchantProfileId + "</MerchantProfileId>"
                            + "<DifferenceData xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions' xmlns:d2p2='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard' i:type='d2p2:BankcardReturn'>"
                                + "<d2p1:TransactionId>" + _LastResponse.TransactionId + "</d2p1:TransactionId>"
                                + "<d2p1:TransactionDateTime>" + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffzzz") + "</d2p1:TransactionDateTime>"
                                + "<d2p2:Amount>" + TxtAmount.Text + "</d2p2:Amount>"
                            + "</DifferenceData>"
                            + "</SubmitTransaction>"
                            ;
                    CreateRequest(_txn + @"/" + _WorkflowId, "POST", strReturnById, _SessionToken, "",
                                  TransactionType.ReturnById);
                }
                _LastResponse = null; //clear out the last transaction as no more operations to process

            }
            else
            {
                MessageBox.Show("In order to process a ReturnById a AuthorizeAndCapture or Capture needs to be processed first");
            }
        }

        private void ReturnUnlinked()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strAuthorizeAndCaptureRequest =
                    "{\"$type\":\"ReturnTransaction,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                    + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                    + "\"MerchantProfileId\":\"" + _MerchantProfileId + "\","
                    + buildTransaction_Json()
                    + "}"
                    ;

                CreateRequest_Json(_txn + @"/" + _WorkflowId, "POST", strAuthorizeAndCaptureRequest, _SessionToken, "",
                              TransactionType.ReturnUnlinked);
            }
            else
            {
                string strAuthorizeAndCaptureRequest = "<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='ReturnTransaction' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                                        + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                                        + "<MerchantProfileId>" + _MerchantProfileId + "</MerchantProfileId>"
                                        + buildTransaction()
                                        + "</SubmitTransaction>"
                                        ;

                CreateRequest(_txn + @"/" + _WorkflowId, "POST", strAuthorizeAndCaptureRequest, _SessionToken, "",
                              TransactionType.ReturnUnlinked);
            }
        }

        private void Undo()
        {
            if (_LastResponse != null && _LastResponse.TransactionType == TransactionType.Authorize)
            {
                if (ChkUseJsonInstead.Checked)
                {
                    string strUndoRequest =
                        "{\"$type\":\"Undo,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                            + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                            + "\"DifferenceData\":"
                            + "{\"$type\":\"BankcardUndo,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard\","
                                + "\"TransactionId\":\"" + _LastResponse.TransactionId + "\","
                                + "\"Addendum\":null"
                            + "}"
                        + "}";

                    CreateRequest_Json(_txn + @"/" + _WorkflowId + @"/" + _LastResponse.TransactionId, "PUT", strUndoRequest,
                                   _SessionToken, "", TransactionType.Undo);
                }
                else
                {
                    string strUndoRequest = @"<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='Undo' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                        + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                        + "<DifferenceData xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions' xmlns:d2p2='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard' i:type='d2p2:BankcardUndo'>"
                            + "<d2p1:TransactionId>" + _LastResponse.TransactionId + "</d2p1:TransactionId>"
                        //+ "<d2p2:PINDebitReason>NotSet</d2p2:PINDebitReason>"
                        + "</DifferenceData>"
                        + "</SubmitTransaction>"
                        ;

                    CreateRequest(_txn + @"/" + _WorkflowId + @"/" + _LastResponse.TransactionId, "PUT", strUndoRequest,
                                  _SessionToken, "", TransactionType.Undo);
                }

                _LastResponse = null; //Clear out last transactiontype as no follow-on transactions are related to Undo
            }
            else
            {
                MessageBox.Show("In order to process an Undo a Authorize needs to be processed first");
            }
        }

        private void Verify()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strVerifyRequest =
                    "{\"$type\":\"AuthorizeTransaction,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest\","
                    + "\"ApplicationProfileId\":\"" + _ApplicationProfileId + "\","
                    + "\"MerchantProfileId\":\"" + _MerchantProfileId + "\","
                    + buildTransaction_Json()
                    + "}"
                    ;

                CreateRequest_Json(_txn + @"/" + _WorkflowId + @"/verify", "POST", strVerifyRequest, _SessionToken, "",
                              TransactionType.Verify);
            }
            else
            {
                string strVerifyRequest = "<SubmitTransaction xmlns:i='http://www.w3.org/2001/XMLSchema-instance' i:type='AuthorizeTransaction' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Rest'>"
                                           + "<ApplicationProfileId>" + _ApplicationProfileId + "</ApplicationProfileId>"
                                           + "<MerchantProfileId>" + _MerchantProfileId + "</MerchantProfileId>"
                                           + buildTransaction()
                                           + "</SubmitTransaction>"
                    ;

                CreateRequest(_txn + @"/" + _WorkflowId + @"/verify", "POST", strVerifyRequest, _SessionToken, "",
                              TransactionType.Verify);
            }
        }

        private string buildTransaction()
        {
            string txn = "";
            string trackData = "<d2p2:Track1Data i:nil='true'/><d2p2:Track2Data i:nil='true'/>";
            if (_industryTypeValues.EntryMode == "TrackDataFromMSR")
            {
                trackData = "<d2p2:Track1Data i:nil='true'/><d2p2:Track2Data>5454545454545454=13121010134988000010</d2p2:Track2Data>";
                //trackData = "<d2p2:Track1Data>B5454545454545454^/TESTCARD^1312101013490000000001000880000</d2p2:Track1Data><d2p2:Track2Data i:nil='true'/>";
            }

            if (ChkProcessAsMagensa.Checked)
            {//Use the Magensa fields below.
                txn = "<Transaction xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions' xmlns:d2p2='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard' i:type='d2p2:BankcardTransaction'>"
                           + "<d2p1:CustomerData i:nil='true'/>"
                           + "<d2p1:ReportingData i:nil='true'/>"
                           + "<d2p1:Addendum i:nil='true'/>"
                           + "<d2p2:ApplicationConfigurationData i:nil='true'/>"
                           + "<d2p2:TenderData>"
                               + "<d2p1:PaymentAccountDataToken i:nil='true'/>"
                               + "<d2p1:SecurePaymentAccountData>13A7783BD91D0A05712606644778CF8F34397EAC2AB26676A52A380350CAA07E</d2p1:SecurePaymentAccountData>"//Used for Magensa
                               + "<d2p1:EncryptionKeyId>9011400B042692000398</d2p1:EncryptionKeyId>"//Used for Magensa
                               + "<d2p1:SwipeStatus>1065057</d2p1:SwipeStatus>"//Used for Magensa
                               + "<d2p2:CardData>"
                                   + "<d2p2:CardType>MasterCard</d2p2:CardType>"
                                   + "<d2p2:CardholderName i:nil='true'/>"
                                   + "<d2p2:PAN>5454545454545454</d2p2:PAN>"
                                   + "<d2p2:Expire>1210</d2p2:Expire>"
                                   + trackData
                    //+ "<d2p2:Track1Data i:nil='true'/>"
                    //+ "<d2p2:Track2Data i:nil='true'/>"
                               + "</d2p2:CardData>"
                               + "<d2p2:CardSecurityData>"
                                   + "<d2p2:AVSData>"
                                       + "<d2p2:CardholderName>SJohnson</d2p2:CardholderName>"
                                       + "<d2p2:Street>777 Cherry Street</d2p2:Street>"
                                       + "<d2p2:City>Denver</d2p2:City>"
                                       + "<d2p2:StateProvince>CO</d2p2:StateProvince>"
                                       + "<d2p2:PostalCode>80220</d2p2:PostalCode>"
                                       + "<d2p2:Country>USA</d2p2:Country>"
                                       + "<d2p2:Phone i:nil='true'/>"
                                   + "</d2p2:AVSData>"
                                   + "<d2p2:CVDataProvided>NotSet</d2p2:CVDataProvided>"//Used for Magensa
                                   + "<d2p2:CVData i:nil='true'/>"//Used for Magensa
                                   + "<d2p2:KeySerialNumber i:nil='true'/>"
                                   + "<d2p2:PIN i:nil='true'/>"
                                   + "<d2p2:Iden" +
                                   "" +
                                   "" +
                                   "" +
                                   "" +
                                   "tificationInformation>A52AFB9FB5B283A6C8C38377A6CB1D2C63CC59D3B0B29D2A0DF1C9A54F123D37536756C77B4A9B75E51BF028B51971E81C8B221533A3AFF4</d2p2:IdentificationInformation>"//Used for Magensa
                               + "</d2p2:CardSecurityData>"
                               + "<d2p2:EcommerceSecurityData i:nil='true'/>"
                           + "</d2p2:TenderData>"
                           + "<d2p2:TransactionData>"
                               + "<d2p1:Amount>10.00</d2p1:Amount>"
                               + "<d2p1:CurrencyCode>USD</d2p1:CurrencyCode>"
                               + "<d2p1:TransactionDateTime>2011-03-21T17:44:13.395+00:00</d2p1:TransactionDateTime>"
                               + "<d2p1:CampaignId i:nil='true'/>"
                               + "<d2p1:Reference>11</d2p1:Reference>"//Used for Magensa
                               + "<d2p2:AccountType>NotSet</d2p2:AccountType>"
                    //Soft Descriptors
                               + "<d2p2:AlternativeMerchantData>"
                                   + "<d2p1:CustomerServiceInternet>www.test.com</d2p1:CustomerServiceInternet>"
                                   + "<d2p1:CustomerServicePhone>303 3575700</d2p1:CustomerServicePhone>"
                                   + "<d2p1:Description i:nil='true'/>"
                                   + "<d2p1:SIC i:nil='true'/>"
                                   + "<d2p1:Address>"
                                       + "<d2p1:Street1>1234 Happy St</d2p1:Street1>"
                                       + "<d2p1:Street2 i:nil='true'/>"
                                       + "<d2p1:City>Denver</d2p1:City>"
                                       + "<d2p1:StateProvince>CO</d2p1:StateProvince>"
                                       + "<d2p1:PostalCode>80023</d2p1:PostalCode>"
                                       + "<d2p1:CountryCode>USA</d2p1:CountryCode>"
                                   + "</d2p1:Address>"
                                   + "<d2p1:MerchantId i:nil='true'/>"
                                   + "<d2p1:Name>ABC Merchant</d2p1:Name>"
                               + "</d2p2:AlternativeMerchantData>"
                               + "<d2p2:ApprovalCode i:nil='true'/>"
                               + "<d2p2:CashBackAmount>0.00</d2p2:CashBackAmount>"
                               + "<d2p2:CustomerPresent>" + _industryTypeValues.CustomerPresent + "</d2p2:CustomerPresent>"
                               + "<d2p2:EmployeeId>12345</d2p2:EmployeeId>"
                               + "<d2p2:EntryMode>TrackDataFromMSR</d2p2:EntryMode>"//Used for Magensa
                               + "<d2p2:GoodsType>PhysicalGoods</d2p2:GoodsType>"
                               + "<d2p2:IndustryType>" + _industryTypeValues.IndustryType + "</d2p2:IndustryType>"
                               + "<d2p2:InternetTransactionData>"
                                   + "<d2p2:IpAddress>1.1.1.1</d2p2:IpAddress>"
                                   + "<d2p2:SessionId>12345</d2p2:SessionId>"
                               + "</d2p2:InternetTransactionData>"
                               + "<d2p2:InvoiceNumber i:nil='true'/>"
                               + "<d2p2:OrderNumber>12345</d2p2:OrderNumber>"
                               + "<d2p2:IsPartialShipment>false</d2p2:IsPartialShipment>"
                               + "<d2p2:SignatureCaptured>false</d2p2:SignatureCaptured>"
                               + "<d2p2:TerminalId i:nil='true'/>"
                               + "<d2p2:LaneId>1</d2p2:LaneId>"
                               + "<d2p2:TipAmount>0.00</d2p2:TipAmount>"
                               + "<d2p2:BatchAssignment i:nil='true'/>"
                               + "<d2p2:ScoreThreshold>.5</d2p2:ScoreThreshold>"//Used for Magensa
                           + "</d2p2:TransactionData>"
                        + "</Transaction>"
                    ;
            }
            else
            {
                txn = "<Transaction xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions' xmlns:d2p2='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard' i:type='d2p2:BankcardTransaction'>"
                       + "<d2p1:CustomerData i:nil='true'/>"
                       + "<d2p1:ReportingData i:nil='true'/>"
                       + "<d2p1:Addendum i:nil='true'/>"
                       + "<d2p2:ApplicationConfigurationData i:nil='true'/>"
                       + "<d2p2:TenderData>"
                           + "<d2p1:PaymentAccountDataToken i:nil='true'/>"
                           + "<d2p1:SecurePaymentAccountData i:nil='true'/>"
                           + "<d2p1:EncryptionKeyId i:nil='true'/>"
                           + "<d2p1:SwipeStatus i:nil='true'/>"
                           + "<d2p2:CardData>"
                               + "<d2p2:CardType>MasterCard</d2p2:CardType>"
                               + "<d2p2:CardholderName i:nil='true'/>"
                               + "<d2p2:PAN>5454545454545454</d2p2:PAN>"
                               + "<d2p2:Expire>1210</d2p2:Expire>"
                                   + trackData
                    //+ "<d2p2:Track1Data i:nil='true'/>"
                    //+ "<d2p2:Track2Data i:nil='true'/>"
                           + "</d2p2:CardData>"
                           + "<d2p2:CardSecurityData>"
                               + "<d2p2:AVSData>"
                                   + "<d2p2:CardholderName>SJohnson</d2p2:CardholderName>"
                                   + "<d2p2:Street>777 Cherry Street</d2p2:Street>"
                                   + "<d2p2:City>Denver</d2p2:City>"
                                   + "<d2p2:StateProvince>CO</d2p2:StateProvince>"
                                   + "<d2p2:PostalCode>80220</d2p2:PostalCode>"
                                   + "<d2p2:Country>USA</d2p2:Country>"
                                   + "<d2p2:Phone i:nil='true'/>"
                               + "</d2p2:AVSData>"
                               + "<d2p2:CVDataProvided>Provided</d2p2:CVDataProvided>"
                               + "<d2p2:CVData>123</d2p2:CVData>"
                               + "<d2p2:KeySerialNumber i:nil='true'/>"
                               + "<d2p2:PIN i:nil='true'/>"
                               + "<d2p2:IdentificationInformation i:nil='true'/>"
                           + "</d2p2:CardSecurityData>"
                           + "<d2p2:EcommerceSecurityData i:nil='true'/>"
                       + "</d2p2:TenderData>"
                       + "<d2p2:TransactionData>"
                           + "<d2p1:Amount>10.00</d2p1:Amount>"
                           + "<d2p1:CurrencyCode>USD</d2p1:CurrencyCode>"
                           + "<d2p1:TransactionDateTime>2011-03-21T17:44:13.395+00:00</d2p1:TransactionDateTime>"
                           + "<d2p1:CampaignId i:nil='true'/>"
                           + "<d2p1:Reference i:nil='true'/>"
                           + "<d2p2:AccountType>NotSet</d2p2:AccountType>"
                    //Soft Descriptors
                           + "<d2p2:AlternativeMerchantData>"
                               + "<d2p1:CustomerServiceInternet>www.test.com</d2p1:CustomerServiceInternet>"
                               + "<d2p1:CustomerServicePhone>303 3575700</d2p1:CustomerServicePhone>"
                               + "<d2p1:Description i:nil='true'/>"
                               + "<d2p1:SIC i:nil='true'/>"
                               + "<d2p1:Address>"
                                   + "<d2p1:Street1>1234 Happy St</d2p1:Street1>"
                                   + "<d2p1:Street2 i:nil='true'/>"
                                   + "<d2p1:City>Denver</d2p1:City>"
                                   + "<d2p1:StateProvince>CO</d2p1:StateProvince>"
                                   + "<d2p1:PostalCode>80023</d2p1:PostalCode>"
                                   + "<d2p1:CountryCode>USA</d2p1:CountryCode>"
                               + "</d2p1:Address>"
                               + "<d2p1:MerchantId i:nil='true'/>"
                               + "<d2p1:Name>ABC Merchant</d2p1:Name>"
                           + "</d2p2:AlternativeMerchantData>"
                           + "<d2p2:ApprovalCode i:nil='true'/>"
                           + "<d2p2:CashBackAmount>0.00</d2p2:CashBackAmount>"
                           + "<d2p2:CustomerPresent>" + _industryTypeValues.CustomerPresent + "</d2p2:CustomerPresent>"
                           + "<d2p2:EmployeeId>12345</d2p2:EmployeeId>"
                           + "<d2p2:EntryMode>" + _industryTypeValues.EntryMode + "</d2p2:EntryMode>"
                           + "<d2p2:GoodsType>PhysicalGoods</d2p2:GoodsType>"
                           + "<d2p2:IndustryType>" + _industryTypeValues.IndustryType + "</d2p2:IndustryType>"
                           + "<d2p2:InternetTransactionData>"
                               + "<d2p2:IpAddress>1.1.1.1</d2p2:IpAddress>"
                               + "<d2p2:SessionId>12345</d2p2:SessionId>"
                           + "</d2p2:InternetTransactionData>"
                           + "<d2p2:InvoiceNumber i:nil='true'/>"
                           + "<d2p2:OrderNumber>12345</d2p2:OrderNumber>"
                           + "<d2p2:IsPartialShipment>false</d2p2:IsPartialShipment>"
                           + "<d2p2:SignatureCaptured>false</d2p2:SignatureCaptured>"
                           + "<d2p2:TerminalId i:nil='true'/>"
                           + "<d2p2:LaneId>1</d2p2:LaneId>"
                           + "<d2p2:TipAmount>0.00</d2p2:TipAmount>"
                           + "<d2p2:BatchAssignment i:nil='true'/>"
                           + "<d2p2:ScoreThreshold i:nil='true'/>"
                       + "</d2p2:TransactionData>"
                    + "</Transaction>"
                ;
            }
            return txn;
        }

        private string buildTransaction_Json()
        {
            string txn = "";

            string trackData = "\"Track1Data\":null, \"Track2Data\":null";
            if (_industryTypeValues.EntryMode == "TrackDataFromMSR")
            {
                trackData = "\"Track1Data\":null, \"Track2Data\":\"5454545454545454=13121010134988000010\"";
                //trackData = "\"Track1Data\":\"B5454545454545454^NAB/TESTCARD^1312101013490000000001000880000\", \"Track2Data\":null";
            }

            if (ChkProcessAsMagensa.Checked)
            {//Use the Magensa fields below.
                txn = "\"Transaction\":"
                    + "{"
                        + "\"$type\":\"BankcardTransaction,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard\","
                        + "\"CustomerData\":null,"
                        + "\"ReportingData\":null,"
                        + "\"Addendum\":"
                        + "{"
                            + "\"Unmanaged\":"
                            + "{"
                                + "\"Any\":[\"<UserId>DougTest</UserId>\",\"<Password>Tests</Password>\"]"
                            + "}"
                        + "},"
                        + "\"ApplicationConfigurationData\":null,"
                        + "\"TenderData\":"
                        + "{"
                            + "\"PaymentAccountDataToken\":null,"
                            + "\"SecurePaymentAccountData\":\"13A7783BD91D0A05712606644778CF8F34397EAC2AB26676A52A380350CAA07E\","//Used for Magensa
                            + "\"EncryptionKeyId\":\"9011400B042692000398\","//Used for Magensa
                            + "\"SwipeStatus\":\"1065057\","//Used for Magensa
                            + "\"CardData\":"
                            + "{"
                                + "\"CardType\":\"MasterCard\","
                                + "\"CardholderName\":null,"
                                + "\"PAN\":\"5454545454545454\","
                                + "\"Expire\":\"1210\","
                                + trackData
                    //+ "\"Track1Data\":null,"
                    //+ "\"Track2Data\":null"
                            + "},"
                            + "\"CardSecurityData\":"
                            + "{"
                                + "\"AVSData\":"
                                + "{"
                                    + "\"CardholderName\":\"SJohnson\","
                                    + "\"Street\":\"777 Cherry Street\","
                                    + "\"City\":\"Denver\","
                                    + "\"StateProvince\":\"CO\","
                                    + "\"PostalCode\":\"80220\","
                                    + "\"Country\":\"USA\","
                                    + "\"Phone\":null"
                                + "},"
                                + "\"CVDataProvided\":\"NotSet\","//Used for Magensa
                                + "\"CVData\":null,"//Used for Magensa
                                + "\"KeySerialNumber\":null,"
                                + "\"PIN\":null,"
                                + "\"IdentificationInformation\":\"A52AFB9FB5B283A6C8C38377A6CB1D2C63CC59D3B0B29D2A0DF1C9A54F123D37536756C77B4A9B75E51BF028B51971E81C8B221533A3AFF4\""//Used for Magensa
                            + "},"
                            + "\"EcommerceSecurityData\":null"
                            + "},"
                            + "\"TransactionData\":"
                            + "{"
                                + "\"Amount\":\"10.00\","
                                + "\"CurrencyCode\":\"USD\","
                                + "\"TransactionDateTime\":\"2012-03-22T14:57:28-06:00\","
                                + "\"CampaignId\":null,"//Used for MPP
                                + "\"Reference\":\"11\","//Used for Magensa
                                + "\"AccountType\":\"NotSet\","
                    //Soft Descriptors - Not supported by all service providers
                    //+ "\"AlternativeMerchantData\":null,"           
                                + "\"AlternativeMerchantData\":"
                                + "{"
                                    + "\"CustomerServiceInternet\":\"www.test.com\","
                                    + "\"CustomerServicePhone\":\"303 3575700\","
                                    + "\"Description\":null,"
                                    + "\"SIC\":null,"
                                    + "\"Address\":{"
                                        + "\"Street1\":\"1234 Happy St\","
                                        + "\"Street2\":\"\","
                                        + "\"City\":\"Denver\","
                                        + "\"StateProvince\":\"CO\","
                                        + "\"PostalCode\":\"80023\","
                                        + "\"CountryCode\":\"USA\""
                                    + "},"
                                    + "\"MerchantId\":null,"
                                    + "\"Name\":\"ABC Merchant\""
                                + " },"
                    //END Soft Descriptors - Not supported by all service providers
                            + "\"ApprovalCode\":null,"
                            + "\"CashBackAmount\":\"0.00\","
                            + "\"CustomerPresent\":\"" + _industryTypeValues.CustomerPresent + "\","
                            + "\"EmployeeId\":\"12345\","
                            + "\"EntryMode\":\"TrackDataFromMSR\","//Used for Magensa
                            + "\"GoodsType\":\"PhysicalGoods\","
                            + "\"IndustryType\":\"" + _industryTypeValues.IndustryType + "\","
                            + "\"InternetTransactionData\":"
                            + "{"
                                + "\"IpAddress\":\"1.1.1.1\","
                                + "\"SessionId\":\"12345\""
                            + "},"
                            + "\"InvoiceNumber\":null,"
                            + "\"OrderNumber\":\"12345\","
                            + "\"IsPartialShipment\":false,"
                            + "\"SignatureCaptured\":false,"
                            + "\"FeeAmount\":\"0.00\","
                            + "\"TerminalId\":null,"
                            + "\"LaneId\":\"9\","
                            + "\"TipAmount\":\"0.00\","
                            + "\"BatchAssignment\":null,"
                            + "\"ScoreThreshold\":\".5\""//Used for Magensa
                        + "}"
                    + "}"
                ;
                /* With Interchange Data. Just comment out the above.
                txn = "\"Transaction\":"
                    + "{"
                        + "\"$type\":\"BankcardTransactionPro,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard/Pro\","
                        + "\"CustomerData\":null,"
                        + "\"ReportingData\":null,"
                        + "\"Addendum\":"
                        + "{"
                            + "\"Unmanaged\":"
                            + "{"
                                + "\"Any\":[\"<UserId>DougTest</UserId>\",\"<Password>Tests</Password>\"]"
                            + "}"
                        + "},"
                        + "\"ApplicationConfigurationData\":null,"
                        + "\"TenderData\":"
                        + "{"
                            + "\"PaymentAccountDataToken\":null,\""
                            + "SecurePaymentAccountData\":null,"
                            + "\"CardData\":"
                            + "{"
                                + "\"CardType\":\"MasterCard\","
                                + "\"CardholderName\":null,"
                                + "\"PAN\":\"5454545454545454\","
                                + "\"Expire\":\"1210\","
                                + trackData
                                //+ "\"Track1Data\":null,"
                                //+ "\"Track2Data\":null"
                            + "},"
                            + "\"CardSecurityData\":"
                            + "{"
                                + "\"AVSData\":"
                                + "{"
                                    + "\"CardholderName\":\"SJohnson\","
                                    + "\"Street\":\"777 Cherry Street\","
                                    + "\"City\":\"Denver\","
                                    + "\"StateProvince\":\"CO\","
                                    + "\"PostalCode\":\"80220\","
                                    + "\"Country\":\"USA\","
                                    + "\"Phone\":null"
                                + "},"
                                + "\"CVDataProvided\":\"Provided\","
                                + "\"CVData\":\"123\","
                                + "\"KeySerialNumber\":null,"
                                + "\"PIN\":null"
                            + "},"
                            + "\"EcommerceSecurityData\":null},"
                            + "\"TransactionData\":"
                            + "{"
                                + "\"Amount\":\"10.00\","
                                + "\"CurrencyCode\":\"USD\","
                                + "\"TransactionDateTime\":\"2012-03-22T14:57:28-06:00\","
                                + "\"AccountType\":\"NotSet\","
                                //Soft Descriptors - Not supported by all service providers
                                //+ "\"AlternativeMerchantData\":null,"           
                                + "\"AlternativeMerchantData\":{"
                                + "\"CustomerServiceInternet\":\"www.test.com\","
                                + "\"CustomerServicePhone\":\"303 3575700\","
                                + "\"Description\":null,"
                                + "\"SIC\":null,"
                                + "\"Address\":{"
                                    + "\"Street1\":\"1234 Happy St\","
                                    + "\"Street2\":\"\","
                                    + "\"City\":\"Denver\","
                                    + "\"StateProvince\":\"CO\","
                                    + "\"PostalCode\":\"80023\","
                                    + "\"CountryCode\":\"USA\""
                                + "},"
                                + "\"MerchantId\":null,"
                                + "\"Name\":\"ABC Merchant\""
                                + " },"
                                //END Soft Descriptors - Not supported by all service providers
                                + "\"ApprovalCode\":null,"
                                + "\"CashBackAmount\":\"0.00\","
                                + "\"CustomerPresent\":\"BillPayment\","
                                + "\"EmployeeId\":\"12345\","
                                + "\"EntryMode\":\"" + _industryTypeValues.EntryMode + "\","
                                + "\"GoodsType\":\"PhysicalGoods\","
                                + "\"IndustryType\":\"" + _industryTypeValues.IndustryType + "\","
                                + "\"InternetTransactionData\":"
                                + "{"
                                + "\"IpAddress\":\"1.1.1.1\","
                                + "\"SessionId\":\"12345\""
                            + "},"
                            + "\"InvoiceNumber\":null,"
                            + "\"OrderNumber\":\"12345\","
                            + "\"IsPartialShipment\":false,"
                            + "\"SignatureCaptured\":false,"
                            + "\"FeeAmount\":\"0.00\","
                            + "\"TerminalId\":null,"
                            + "\"LaneId\":\"9\","
                            + "\"TipAmount\":\"0.00\","
                            + "\"BatchAssignment\":null"
                        + "},"
                        + "\"InterchangeData\":"
                        + "{"
                            + "\"BillPayment\":\"Recurring\","
                            + "\"ExistingDebt\":\"NotExistingDebt\","
                            + "\"TotalNumberOfInstallments\":\"3\","
                            + "\"CurrentInstallmentNumber\":\"1\""
                        + "}"
                    + "}"
                ;                     
                 
                 */
            }
            else
            {
                txn = "\"Transaction\":"
                    + "{"
                        + "\"$type\":\"BankcardTransaction,http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard\","
                        + "\"CustomerData\":null,"
                        + "\"ReportingData\":null,"
                        + "\"Addendum\":"
                        + "{"
                            + "\"Unmanaged\":"
                            + "{"
                                + "\"Any\":[\"<UserId>DougTest</UserId>\",\"<Password>Tests</Password>\"]"
                            + "}"
                        + "},"
                        + "\"ApplicationConfigurationData\":null,"
                        + "\"TenderData\":"
                        + "{"
                            + "\"PaymentAccountDataToken\":null,\""
                            + "SecurePaymentAccountData\":null,"
                            + "\"CardData\":"
                            + "{"
                                + "\"CardType\":\"MasterCard\","
                                + "\"CardholderName\":null,"
                                + "\"PAN\":\"5454545454545454\","
                                + "\"Expire\":\"1210\","
                                + trackData
                    //+ "\"Track1Data\":null,"
                    //+ "\"Track2Data\":null"
                            + "},"
                            + "\"CardSecurityData\":"
                            + "{"
                                + "\"AVSData\":"
                                + "{"
                                    + "\"CardholderName\":\"SJohnson\","
                                    + "\"Street\":\"777 Cherry Street\","
                                    + "\"City\":\"Denver\","
                                    + "\"StateProvince\":\"CO\","
                                    + "\"PostalCode\":\"80220\","
                                    + "\"Country\":\"USA\","
                                    + "\"Phone\":null"
                                + "},"
                                + "\"CVDataProvided\":\"Provided\","
                                + "\"CVData\":\"123\","
                                + "\"KeySerialNumber\":null,"
                                + "\"PIN\":null"
                            + "},"
                            + "\"EcommerceSecurityData\":null},"
                            + "\"TransactionData\":"
                            + "{"
                                + "\"Amount\":\"10.00\","
                                + "\"CurrencyCode\":\"USD\","
                                + "\"TransactionDateTime\":\"2012-03-22T14:57:28-06:00\","
                                + "\"AccountType\":\"NotSet\","
                    //Soft Descriptors - Not supported by all service providers
                    //+ "\"AlternativeMerchantData\":null,"           
                                + "\"AlternativeMerchantData\":{"
                                + "\"CustomerServiceInternet\":\"www.test.com\","
                                + "\"CustomerServicePhone\":\"303 3575700\","
                                + "\"Description\":null,"
                                + "\"SIC\":null,"
                                + "\"Address\":{"
                                    + "\"Street1\":\"1234 Happy St\","
                                    + "\"Street2\":\"\","
                                    + "\"City\":\"Denver\","
                                    + "\"StateProvince\":\"CO\","
                                    + "\"PostalCode\":\"80023\","
                                    + "\"CountryCode\":\"USA\""
                                + "},"
                                + "\"MerchantId\":null,"
                                + "\"Name\":\"ABC Merchant\""
                                + " },"
                    //END Soft Descriptors - Not supported by all service providers
                                + "\"ApprovalCode\":null,"
                                + "\"CashBackAmount\":\"0.00\","
                                + "\"CustomerPresent\":\"" + _industryTypeValues.CustomerPresent + "\","
                                + "\"EmployeeId\":\"12345\","
                                + "\"EntryMode\":\"" + _industryTypeValues.EntryMode + "\","
                                + "\"GoodsType\":\"PhysicalGoods\","
                                + "\"IndustryType\":\"" + _industryTypeValues.IndustryType + "\","
                                + "\"InternetTransactionData\":"
                                + "{"
                                + "\"IpAddress\":\"1.1.1.1\","
                                + "\"SessionId\":\"12345\""
                            + "},"
                            + "\"InvoiceNumber\":null,"
                            + "\"OrderNumber\":\"12345\","
                            + "\"IsPartialShipment\":false,"
                            + "\"SignatureCaptured\":false,"
                            + "\"FeeAmount\":\"0.00\","
                            + "\"TerminalId\":null,"
                            + "\"LaneId\":\"9\","
                            + "\"TipAmount\":\"0.00\","
                            + "\"BatchAssignment\":null"
                        + "}"
                    + "}"
                ;
            }
            if (_industryTypeValues.EntryMode == "TrackDataFromMSR")
            {//Replace with a value if TrackDataFromMSR
                //txn.Replace("\"Track1Data\":null", "\"Track1Data\":\"B5454545454545454^IPCOMMERCE/TESTCARD^1312101013490000000001000880000\"");
                txn.Replace("\"Track2Data\":null", "\"Track2Data\":\"Track2Data>5454545454545454=13121010134988000010\"");
            }
            return txn;
        }

        #endregion Transaction Processing

        #region Transaction Management Systems

        private void TmsSamples_Click(object sender, EventArgs e)
        {
            if (ChkLstTMSFunctions.SelectedItem == null && ChkLstTMSFunctions.CheckedItems.Count < 1)
            {
                MessageBox.Show("Please select a TMS function to run");
                return;
            }
            foreach (object itemChecked in ChkLstTMSFunctions.CheckedItems)
            {
                if (itemChecked == "QueryBatch")
                    QueryBatch();
                if (itemChecked == "QueryTransactionsSummary")
                    QueryTransactionsSummary();
                if (itemChecked == "QueryTransactionsFamilies")
                    QueryTransactionsFamilies();
                if (itemChecked == "QueryTransactionsDetail")
                    QueryTransactionsDetail();
            }

        }

        private void QueryBatch()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strQueryBatch =
                    "{\"$type\":\"QueryBatch,http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS/Rest\","
                    + PagingParameters_Json()
                    + "\"QueryBatchParameters\":"
                        + "{"
                            + "\"BatchDateRange\":"
                            + "{"
                                + "\"EndDateTime\":\"" + dtpEndTimeTMS.Value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "\","
                                + "\"StartDateTime\":\"" + dtpStartTimeTMS.Value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "\""
                            + "},"
                            + "\"BatchIds\":null,"
                            + "\"MerchantProfileIds\":null,"
                            + "\"ServiceKeys\":null,"
                            + "\"TransactionIds\":null"
                        + "}"
                    + "}"
                    ;

                CreateRequest_Json(_tms + @"/batch", "POST", strQueryBatch, _SessionToken, "", TransactionType.QueryBatch);
            }
            else
            {
                string strQueryBatch =
                    "<QueryBatch xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS/Rest'>"
                    + PagingParameters()
                    + "<QueryBatchParameters xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS'>"
                        + "<d2p1:BatchDateRange xmlns:d3p1='http://schemas.ipcommerce.com/CWS/v2.0/DataServices'>"
                            + "<d3p1:EndDateTime>" + dtpEndTimeTMS.Value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "</d3p1:EndDateTime>"
                            + "<d3p1:StartDateTime>" + dtpStartTimeTMS.Value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "</d3p1:StartDateTime>"
                        + "</d2p1:BatchDateRange>"
                        + "<d2p1:BatchIds xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true'/>"
                        + "<d2p1:MerchantProfileIds xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true'/>"
                        + "<d2p1:ServiceKeys xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true'/>"
                        + "<d2p1:TransactionIds xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true'/>"
                    + "</QueryBatchParameters>"
                    + "</QueryBatch>"
                    ;

                CreateRequest(_tms + @"/batch", "POST", strQueryBatch, _SessionToken, "", TransactionType.QueryBatch);
            }
        }

        private void QueryTransactionsSummary()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strQueryTransactionsSummary =
                    "{\"$type\":\"QueryTransactionsSummary,http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS/Rest\","
                        + "\"IncludeRelated\":false,"
                        + PagingParameters_Json()
                        + QueryTransactionsParameters_Json()
                    + "}"
                    ;

                CreateRequest_Json(_tms + @"/transactionsSummary", "POST", strQueryTransactionsSummary, _SessionToken, "",
                    TransactionType.QueryTransactionsSummary);
            }
            else
            {
                string strQueryTransactionsSummary =
                    "<QueryTransactionsSummary xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS/Rest'>"
                    + "<IncludeRelated>false</IncludeRelated>"
                    + PagingParameters()
                    + QueryTransactionsParameters()
                    + "	<TransactionDetailFormat>CWSTransaction</TransactionDetailFormat>"
                    + "</QueryTransactionsSummary>"
                    ;

                CreateRequest(_tms + @"/transactionsSummary", "POST", strQueryTransactionsSummary, _SessionToken, "",
                    TransactionType.QueryTransactionsSummary);
            }
        }

        private void QueryTransactionsFamilies()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strQueryTransactionsFamilies =
                    "{\"$type\":\"QueryTransactionsFamilies,http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS/Rest\","
                        + PagingParameters_Json()
                        + QueryTransactionsParameters_Json()
                    + "}"
                    ;

                CreateRequest_Json(_tms + @"/transactionsFamily", "POST", strQueryTransactionsFamilies, _SessionToken, "",
                    TransactionType.QueryTransactionsFamilies);
            }
            else
            {
                string strQueryTransactionsFamilies =
                    "<QueryTransactionsFamilies xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS/Rest'>"
                    + PagingParameters()
                    + QueryTransactionsParameters()
                    + "</QueryTransactionsFamilies>"
                    ;

                CreateRequest(_tms + @"/transactionsFamily", "POST", strQueryTransactionsFamilies, _SessionToken, "",
                    TransactionType.QueryTransactionsFamilies);
            }
        }

        private void QueryTransactionsDetail()
        {
            if (ChkUseJsonInstead.Checked)
            {
                string strQueryTransactionsDetail =
                    "{\"$type\":\"QueryTransactionsDetail,http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS/Rest\","
                        + "\"IncludeRelated\":false,"
                        + PagingParameters_Json()
                        + QueryTransactionsParameters_Json()
                    + "}"
                    ;

                CreateRequest_Json(_tms + @"/transactionsDetail", "POST", strQueryTransactionsDetail, _SessionToken, "",
                    TransactionType.QueryTransactionsFamilies);
            }
            else
            {
                string strQueryTransactionsDetail =
                    "<QueryTransactionsDetail xmlns:i='http://www.w3.org/2001/XMLSchema-instance' xmlns='http://schemas.ipcommerce.com/CWS/v2.0/DataServices/TMS/Rest'>"
                    + "<IncludeRelated>false</IncludeRelated>"
                    + PagingParameters()
                    + QueryTransactionsParameters()
                    + "<TransactionDetailFormat>CWSTransaction</TransactionDetailFormat>"
                    + "</QueryTransactionsDetail>"
                    ;

                CreateRequest(_tms + @"/transactionsDetail", "POST", strQueryTransactionsDetail, _SessionToken, "",
                    TransactionType.QueryTransactionsFamilies);
            }
        }

        private string PagingParameters()
        {
            return "<PagingParameters xmlns:d2p1='http://schemas.ipcommerce.com/CWS/v2.0/DataServices'>"
                       + "<d2p1:Page>0</d2p1:Page>"
                       + "<d2p1:PageSize>50</d2p1:PageSize>"
                   + "</PagingParameters>"
                ;
        }

        private string PagingParameters_Json()
        {
            return "\"PagingParameters\":"
                    + "{"
                        + "\"Page\":0,"
                        + "\"PageSize\":50"
                    + "},"
                ;
        }

        private string QueryTransactionsParameters()
        {
            string strTxnId = (TxtTransactionId.Text.Length > 0) ? "<d2p1:TransactionIds xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays'><d3p1:string>" + TxtTransactionId.Text + "</d3p1:string></d2p1:TransactionIds>" : "<d2p1:TransactionIds xmlns:d3p1='http://schemas.ipcommerce.com/CWS/v2.0/DataServices' i:nil='true' />";
            return
                "<QueryTransactionsParameters xmlns:d2p1='http://schemas.ipcommerce" + ".com/CWS/v2.0/DataServices/TMS'>"
                    + "<d2p1:Amounts xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true' />"
                    + "<d2p1:ApprovalCodes xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true' />"
                    + "<d2p1:BatchIds xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true' />"
                    + "<d2p1:CaptureDateRange xmlns:d3p1='http://schemas.ipcommerce.com/CWS/v2.0/DataServices' i:nil='true' />"
                    + "<d2p1:CaptureStates xmlns:d3p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions' i:nil='true' />"
                    + "<d2p1:CardTypes xmlns:d3p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions/Bankcard' i:nil='true' />"
                    + "<d2p1:IsAcknowledged>NotSet</d2p1:IsAcknowledged>"
                    + "<d2p1:MerchantProfileIds xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true' />"
                    + "<d2p1:QueryType>AND</d2p1:QueryType>"
                    + "<d2p1:ServiceIds xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true' />"
                    + "<d2p1:ServiceKeys xmlns:d3p1='http://schemas.microsoft.com/2003/10/Serialization/Arrays' i:nil='true' />"
                    + "<d2p1:TransactionClassTypePairs i:nil='true' />"
                    + "<d2p1:TransactionDateRange xmlns:d3p1='http://schemas.ipcommerce.com/CWS/v2.0/DataServices'>"
                        + "<d3p1:EndDateTime>" + dtpEndTimeTMS.Value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "</d3p1:EndDateTime>"
                        + "<d3p1:StartDateTime>" + dtpStartTimeTMS.Value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "</d3p1:StartDateTime>"
                    + "</d2p1:TransactionDateRange>"
                    + strTxnId
                    + "<d2p1:TransactionStates xmlns:d3p1='http://schemas.ipcommerce.com/CWS/v2.0/Transactions' i:nil='true' />"
                + "</QueryTransactionsParameters>"
                ;
        }

        private string QueryTransactionsParameters_Json()
        {
            string strTxnId = (TxtTransactionId.Text.Length > 0) ? "\"TransactionIds\":[\"" + TxtTransactionId.Text + "\"]," : "\"TransactionIds\":null,";
            return
                "\"QueryTransactionsParameters\":"
                + "{"
                        + "\"Amounts\":null,"
                        + "\"ApprovalCodes\":null,"
                        + "\"BatchIds\":null,"
                        + "\"CaptureDateRange\":null,"
                        + "\"CaptureStates\":null,"
                        + "\"CardTypes\":null,"
                        + "\"IsAcknowledged\":\"NotSet\","
                        + "\"QueryType\":\"AND\","
                        + "\"ServiceIds\":null,"
                        + "\"ServiceKeys\":null,"
                        + "\"TransactionClassTypePairs\":null,"
                        + "\"TransactionDateRange\":"
                            + "{"
                                + "\"EndDateTime\":\"" + dtpEndTimeTMS.Value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "\","
                                + "\"StartDateTime\":\"" + dtpStartTimeTMS.Value.ToUniversalTime().ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss") + "\""
                            + "},"
                        + strTxnId
                        + "\"TransactionStates\":null"
                + "}"
                ;
        }

        #endregion Transaction Management Systems

        #region Generate Samples

        private void CmdGenerateHCSamples_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (CboIndustryType.Text.Length < 1)
            {
                MessageBox.Show("Please select an industry type");
                CboIndustryType.Focus();
                Cursor = Cursors.Default;
                return;
            }
            if (TxtSvcId.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid ServiceId");
                TxtSvcId.Focus();
                Cursor = Cursors.Default;
                return;
            }

            _WorkflowId = TxtSvcId.Text;

            RTxtSummary.Clear();

            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("**************************************************************\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***** Sample REST transactions for Host Capture Services *****\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("**************************************************************\r\n\r\n");

            #region Step1_BuildServiceInfoSamples
            //STEP 1.  Build Service Information Data
            //First generate the ServiceInformation Samples
            BuildServiceInfoSamples();
            #endregion

            #region Step2_TransactionProcessing
            //STEP 2.  Transaction Processing
            //Now process some transactions
            Font currentFont = this.RTxtSummary.SelectionFont;
            FontStyle newFontStyle;
            newFontStyle = FontStyle.Bold;

            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("\r\n\r\n****************************************************************\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***** Transaction Processing Samples ServiceId : " + _WorkflowId + "*****\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("****************************************************************\r\n\r\n");

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** AuthorizeAndCapture *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            AuthorizeAndCapture();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** ReturnById *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            ReturnById();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** Authorize *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            Authorize();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** Undo *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            Undo();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** Authorize *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            Authorize();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** Capture *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            Capture();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** ReturnById *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            ReturnById();
            #endregion

            #region Step3_CleanUpProcess
            //STEP 3:  Clean Up Process
            //Deletion of application and merchant IDs
            if (ChkSaveDeleteApplicationData.Checked)
            {
                RTxtSummary.SelectionColor = Color.DarkMagenta;
                RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
                RTxtSummary.AppendText("\r\n***** DeleteApplicationData *****\r\n\r\n");
                DeleteApplicationData();
            }

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** DeleteMerchantProfileId *****\r\n\r\n");
            DeleteMerchantProfileId("IPC_Test_" + _WorkflowId, TxtSvcId.Text);
            #endregion

            Cursor = Cursors.Default;
        }

        private void CmdGenerateTCSamples_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            if (CboIndustryType.Text.Length < 1)
            {
                MessageBox.Show("Please select an industry type");
                CboIndustryType.Focus();
                Cursor = Cursors.Default;
                return;
            }
            if (TxtSvcId.Text.Length < 1)
            {
                MessageBox.Show("Please enter a valid ServiceId");
                TxtSvcId.Focus();
                Cursor = Cursors.Default;
                return;
            }
            else
            {
                _WorkflowId = TxtSvcId.Text;
            }

            RTxtSummary.Clear();

            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("**************************************************************\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***** Sample REST transactions for Terminal Capture Services *****\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("**************************************************************\r\n\r\n");

            //First generate the ServiceInformation Samples
            BuildServiceInfoSamples();

            //Now process some transactions
            Font currentFont = this.RTxtSummary.SelectionFont;
            FontStyle newFontStyle;
            newFontStyle = FontStyle.Bold;

            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("\r\n\r\n****************************************************************\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***** Transaction Processing Samples ServiceId : " + _WorkflowId + "***************\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("****************************************************************\r\n\r\n");

            //ONLY IF PINDEBIT IS IN SCOPE
            //RTxtSummary.SelectionColor = Color.DarkMagenta;
            //RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            //RTxtSummary.AppendText("\r\n***** AuthorizeAndCapture *****\r\n\r\n");
            //_WorkflowId = _ServiceId;
            //AuthorizeAndCapture();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** Authorize (for ReturnById) *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            Authorize();
            response saveResponse = new response(TransactionType.Authorize, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "");
            saveResponse = _LastResponse;

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** Authorize (for Undo) *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            Authorize();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** Undo *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            Undo();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** ReturnUnlinked *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            ReturnUnlinked();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** CaptureAll *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            CaptureAll();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** ReturnById *****\r\n\r\n");
            _LastResponse = saveResponse;//Set the Authorize response Above 
            _WorkflowId = TxtSvcId.Text;
            ReturnById();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** Authorize (for CaptureSelective) *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            Authorize();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** CaptureSelective *****\r\n\r\n");
            _WorkflowId = TxtSvcId.Text;
            CaptureSelective();

            if (ChkProcessAsMagensa.Checked)
            {
                RTxtSummary.SelectionColor = Color.DarkMagenta;
                RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
                RTxtSummary.AppendText("\r\n***** Authorize (Magensa example) *****\r\n\r\n");
                _WorkflowId = TxtAltWorkFlowId.Text;
                Authorize();
            }

            #region Step3_CleanUpProcess
            //STEP 3:  Clean Up Process
            //Deletion of application and merchant IDs
            if (ChkSaveDeleteApplicationData.Checked)
            {
                RTxtSummary.SelectionColor = Color.DarkMagenta;
                RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
                RTxtSummary.AppendText("\r\n***** DeleteApplicationData *****\r\n\r\n");
                DeleteApplicationData();
            }

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** DeleteMerchantProfileId *****\r\n\r\n");
            DeleteMerchantProfileId("IPC_Test_" + _WorkflowId, TxtSvcId.Text);
            #endregion

            Cursor = Cursors.Default;
        }

        private void BuildServiceInfoSamples()
        {
            Font currentFont = this.RTxtSummary.SelectionFont;
            FontStyle newFontStyle;
            newFontStyle = FontStyle.Bold;

            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***************************************\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***** Service Information Samples *****\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***************************************\r\n\r\n");

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** SignOnWithToken *****\r\n\r\n");
            SignOnWithToken();

            //Manage Application Data
            if (ChkSaveDeleteApplicationData.Checked)
            {
                RTxtSummary.SelectionColor = Color.DarkMagenta;
                RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
                RTxtSummary.AppendText("\r\n***** SaveApplicationData *****\r\n\r\n");
                SaveApplicationData();
                RTxtSummary.SelectionColor = Color.Blue;
                RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
                RTxtSummary.AppendText("\r\n***** NOTE : Once an ApplicationProfileId is obtained it should be saved as a configuration value\r\n and this step skipped as the value is already known. Re-saving application data can lead\r\n to poor application performance *****\r\n\r\n");

            }
            if (_ApplicationProfileId.Length > 0)
            {
                RTxtSummary.SelectionColor = Color.DarkMagenta;
                RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
                RTxtSummary.AppendText("\r\n***** GetApplicationData *****\r\n\r\n");
                GetApplicationData();
            }

            //RTxtSummary.SelectionColor = Color.DarkMagenta;
            //RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            //RTxtSummary.AppendText("\r\n***** DeleteApplicationData *****\r\n\r\n");
            //DeleteApplicationData();

            //RTxtSummary.SelectionColor = Color.Red;
            //RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            //RTxtSummary.AppendText("\r\n***** SaveApplicationData RMOVED THIS ONE AS IT'S EXTRA*****\r\n\r\n");
            //try
            //{//Not sure why delete is causing issues for .NET however a null is returned. Use the following to reset. 
            //    _dtSessionToken = new DateTime();
            //    checkTokenExpire();
            //}catch {}
            //SaveApplicationData();

            //Get Service Information
            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** GetServiceInformation *****\r\n\r\n");
            GetServiceInformation();

            //Manage Merchant Data
            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** SaveMerchantProfile *****\r\n\r\n");
            _MerchantProfileId = "IPC_Test_" + _WorkflowId;

            SaveMerchantProfile();
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** NOTE : Once a MerchantProfileId is saved it should be stored as a configuration value\r\n and this step skipped as the value is already known. Re-saving the same merchant data\r\n can lead to poor application performance. \r\n\r\nOnly in the case of a new merchant profile or Update should the application save new merchant data.*****\r\n\r\n");


            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** GetMerchantProfile *****\r\n\r\n");
            _MerchantProfileId = "IPC_Test_" + _WorkflowId;
            GetMerchantProfile();

            RTxtSummary.SelectionColor = Color.DarkMagenta;
            RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            RTxtSummary.AppendText("\r\n***** GetMerchantProfiles *****\r\n\r\n");
            GetMerchantProfiles();

            //RTxtSummary.SelectionColor = Color.DarkMagenta;
            //RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            //RTxtSummary.AppendText("\r\n***** DeleteMerchantProfileId *****\r\n\r\n");
            //DeleteMerchantProfileId("IPC_Test_" + _WorkflowId, TxtSvcId.Text);

            //RTxtSummary.SelectionColor = Color.Red;
            //RTxtSummary.AppendText("\r\n***** SaveMerchantProfile RMOVED THIS ONE AS IT'S EXTRA*****\r\n\r\n");
            //_MerchantProfileId = "IPC_Test_" + _WorkflowId;
            //try
            //{//Not sure why delete is causing issues for .NET however a null is returned. Use the following to reset. 
            //    _dtSessionToken = new DateTime();
            //    checkTokenExpire();
            //}
            //catch { }
            //SaveMerchantProfile();
            //RTxtSummary.SelectionColor = Color.Blue;
            //RTxtSummary.SelectionFont = new Font(currentFont, newFontStyle);
            //RTxtSummary.AppendText("\r\n***** NOTE : Once a MerchantProfileId is saved it should be stored as a configuration value\r\n and this step skipped as the value is already known. Re-saving the same merchant data\r\n can lead to poor application performance. \r\n\r\nOnly in the case of a new merchant profile or Update should the application save new merchant data.*****\r\n\r\n");


            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("\r\n\r\n***********************************************************\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***** Your Configuration Values include the following *****\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("***********************************************************\r\n\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("ApplicationProfileId : " + _ApplicationProfileId + "\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("ServiceId : " + _WorkflowId + "\r\n");
            RTxtSummary.SelectionColor = Color.Blue;
            RTxtSummary.AppendText("MerchantProfileId : " + _MerchantProfileId + "\r\n\r\n");

        }

        private void CboIndustryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboIndustryType.Text == "Ecommerce")
            {
                _industryTypeValues.ApplicationAttended = "false";
                _industryTypeValues.ApplicationLocation = "OffPremises";
                _industryTypeValues.PINCapability = "PINNotSupported";
                _industryTypeValues.ReadCapability = "KeyOnly";
                _industryTypeValues.IndustryType = "Ecommerce";
                _industryTypeValues.CustomerPresent = "Ecommerce";
                _industryTypeValues.EntryMode = "Keyed";
            }
            if (CboIndustryType.Text == "MOTO")
            {
                _industryTypeValues.ApplicationAttended = "false";
                _industryTypeValues.ApplicationLocation = "OffPremises";
                _industryTypeValues.PINCapability = "PINNotSupported";
                _industryTypeValues.ReadCapability = "KeyOnly";
                _industryTypeValues.IndustryType = "MOTO";
                _industryTypeValues.CustomerPresent = "MOTO";
                _industryTypeValues.EntryMode = "Keyed";
            }
            if (CboIndustryType.Text == "Retail")
            {
                _industryTypeValues.ApplicationAttended = "true";
                _industryTypeValues.ApplicationLocation = "OnPremises";
                _industryTypeValues.PINCapability = "PINNotSupported";
                _industryTypeValues.ReadCapability = "HasMSR";
                _industryTypeValues.IndustryType = "Retail";
                _industryTypeValues.CustomerPresent = "Present";
                _industryTypeValues.EntryMode = "TrackDataFromMSR";//<!-- [Ecommerce/MOTO : Keyed] [Retail/Restaurant : Keyed/TrackDataFromMSR] -->
            }
            if (CboIndustryType.Text == "Restaurant")
            {
                _industryTypeValues.ApplicationAttended = "true";
                _industryTypeValues.ApplicationLocation = "OnPremises";
                _industryTypeValues.PINCapability = "PINNotSupported";
                _industryTypeValues.ReadCapability = "HasMSR";
                _industryTypeValues.IndustryType = "Restaurant";
                _industryTypeValues.CustomerPresent = "Present";
                _industryTypeValues.EntryMode = "TrackDataFromMSR";//<!-- [Ecommerce/MOTO : Keyed] [Retail/Restaurant : Keyed/TrackDataFromMSR] -->
            }

        }

        #endregion Generate Samples

        public response ProcessResponse(string _Response, TransactionType _transactionType)
        {
            //if (_Response.Response is BankcardTransactionResponsePro)
            //{//In the 1.17.11 release all response objects are BankcardTransactionResponsePro
            //    return ProcessBankcardTransactionResponsePro(_Response);
            //}
            try
            {
                XmlDocument response = new XmlDocument();
                response.LoadXml(_Response);
                //Check what kind of response we're processing
                if (response.DocumentElement.Name == "BankcardTransactionResponsePro")
                    return ProcessBankcardTransactionResponsePro(response, _transactionType);
                if (response.DocumentElement.Name == "BankcardCaptureResponse")
                    return BankcardCaptureResponse(response, _transactionType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public response ProcessResponse_Json(string _Response, TransactionType _transactionType)
        {
            //if (_Response.Response is BankcardTransactionResponsePro)
            //{//In the 1.17.11 release all response objects are BankcardTransactionResponsePro
            //    return ProcessBankcardTransactionResponsePro(_Response);
            //}
            try
            {
                //XmlDocument response = new XmlDocument();
                //response.LoadXml(_Response);
                ////Check what kind of response we're processing
                //if (response.DocumentElement.Name == "BankcardTransactionResponsePro")
                return ProcessBankcardTransactionResponsePro_Json(_Response, _transactionType);
            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }

        private response ProcessBankcardTransactionResponsePro(XmlDocument _response, TransactionType _transactionType)
        {
            try
            {
                response r = new response(_transactionType, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
                                          "", "", "", "", "", "", "", "", "", "", "", "", "");

                //First Check to see if this was a transaction
                XmlNodeList nodes = _response.GetElementsByTagName("Status");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.Status = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("StatusCode");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.StatusCode = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("StatusMessage");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.StatusMessage = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("TransactionId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.TransactionId = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("OriginatorTransactionId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.OriginatorTransactionId = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("ServiceTransactionId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.ServiceTransactionId = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("CaptureState");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.CaptureState = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("TransactionState");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.TransactionState = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("Amount");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.Amount = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("CardType");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.CardType = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("FeeAmount");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.FeeAmount = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("ApprovalCode");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.ApprovalCode = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("AVSResult");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                {
                    foreach (XmlNode n in nodes[0])
                    {
                        if (n.InnerXml.Length > 0 && n.InnerText != "NotSet")
                            r.AVSResult = r.AVSResult + "\r\n" + n.Name + " : " + n.InnerText;
                        ;
                    }
                }

                nodes = _response.GetElementsByTagName("BatchId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.BatchId = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("CVResult");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.CVResult = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("CardLevel");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.CardLevel = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("DowngradeCode");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.DowngradeCode = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("MaskedPAN");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.MaskedPAN = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("PaymentAccountDataToken");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.PaymentAccountDataToken = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("RetrievalReferenceNumber");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.RetrievalReferenceNumber = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("Resubmit");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.Resubmit = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("SettlementDate");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.SettlementDate = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("FinalBalance");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.FinalBalance = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("OrderId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.OrderId = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("CashBackAmount");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.CashBackAmount = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("AdviceResponse");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.AdviceResponse = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("CommercialCardResponse");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.CommercialCardResponse = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("ReturnedACI");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.ReturnedACI = nodes[0].InnerText;

                return r;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred when displaying results for " + ex.Message);
                return null;
            }
        }

        private response BankcardCaptureResponse(XmlDocument _response, TransactionType _transactionType)
        {
            try
            {
                response r = new response(_transactionType, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
                                          "", "", "", "", "", "", "", "", "", "", "", "", "");

                //First Check to see if this was a transaction
                XmlNodeList nodes = _response.GetElementsByTagName("Status");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.Status = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("StatusCode");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.StatusCode = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("StatusMessage");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.StatusMessage = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("TransactionId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.TransactionId = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("OriginatorTransactionId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.OriginatorTransactionId = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("ServiceTransactionId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.ServiceTransactionId = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("CaptureState");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.CaptureState = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("TransactionState");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.TransactionState = nodes[0].InnerText;

                nodes = _response.GetElementsByTagName("BatchId");
                if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                    r.BatchId = nodes[0].InnerText;

                return r;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred when displaying results for " + ex.Message);
                return null;
            }
        }

        private response ProcessBankcardTransactionResponsePro_Json(string _response, TransactionType _transactionType)
        {
            try
            {
                response r = new response(_transactionType, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "",
                                          "", "", "", "", "", "", "", "", "", "", "", "", "");

                //TODO : Figure out how to easily parse the JSON
                //First Check to see if this was a transaction
                //XmlNodeList nodes = _response.GetElementsByTagName("Status");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.Status = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("StatusCode");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.StatusCode = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("StatusMessage");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.StatusMessage = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("TransactionId");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")

                //ToDo : Need a better approach to parse a Json Response
                r.TransactionId = _response.Substring(_response.IndexOf("\"TransactionId\":\"") + 17, 32);
                r.TransactionType = _transactionType;

                //nodes = _response.GetElementsByTagName("OriginatorTransactionId");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.OriginatorTransactionId = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("ServiceTransactionId");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.ServiceTransactionId = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("CaptureState");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.CaptureState = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("TransactionState");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.TransactionState = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("Amount");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //ToDo : Need a better approach to parse a Json Response
                r.Amount = _response.Substring(_response.IndexOf("\"Amount\":") + 9, 5);

                //nodes = _response.GetElementsByTagName("CardType");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.CardType = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("FeeAmount");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.FeeAmount = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("ApprovalCode");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.ApprovalCode = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("AVSResult");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //{
                //    foreach (XmlNode n in nodes[0])
                //    {
                //        if (n.InnerXml.Length > 0 && n.InnerText != "NotSet")
                //            r.AVSResult = r.AVSResult + "\r\n" + n.Name + " : " + n.InnerText;
                //        ;
                //    }
                //}

                //nodes = _response.GetElementsByTagName("BatchId");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.BatchId = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("CVResult");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.CVResult = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("CardLevel");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.CardLevel = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("DowngradeCode");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.DowngradeCode = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("MaskedPAN");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.MaskedPAN = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("PaymentAccountDataToken");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.PaymentAccountDataToken = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("RetrievalReferenceNumber");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.RetrievalReferenceNumber = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("Resubmit");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.Resubmit = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("SettlementDate");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.SettlementDate = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("FinalBalance");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.FinalBalance = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("OrderId");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.OrderId = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("CashBackAmount");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.CashBackAmount = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("AdviceResponse");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.AdviceResponse = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("CommercialCardResponse");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.CommercialCardResponse = nodes[0].InnerText;

                //nodes = _response.GetElementsByTagName("ReturnedACI");
                //if (nodes != null && nodes.Count > 0 && nodes[0].InnerText != "NotSet")
                //    r.ReturnedACI = nodes[0].InnerText;

                return r;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred when displaying results for " + ex.Message);
                return null;
            }
        }

        public static String PrettyPrint(String XML)
        {
            String Result = "";

            MemoryStream MS = new MemoryStream();
            XmlTextWriter W = new XmlTextWriter(MS, Encoding.Unicode);
            XmlDocument D = new XmlDocument();

            try
            {
                // Load the XmlDocument with the XML.
                D.LoadXml(XML);

                W.Formatting = Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                D.WriteContentTo(W);
                W.Flush();
                MS.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                MS.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader SR = new StreamReader(MS);

                // Extract the text from the StreamReader.
                String FormattedXML = SR.ReadToEnd();

                Result = FormattedXML;
            }
            catch (XmlException)
            {
            }

            MS.Close();
            W.Close();

            return Result;
        }

        private void tbTransactionProcessing_Enter(object sender, EventArgs e)
        {
            GetConfigurationValues();
        }

        private void TxtLoadIdentityToken_Click(object sender, EventArgs e)
        {
            if (TxtLoadIdentityToken.Text == "[Override App.Config IdentityToken]")
                TxtLoadIdentityToken.Text = "";
        }

        private void TxtLoadIdentityToken_TextChanged(object sender, EventArgs e)
        {
            _IdentityToken = TxtLoadIdentityToken.Text;
        }

        private void CboPTLSVersion_TextChanged(object sender, EventArgs e)
        {
            SetEndpoints();
        }

        private void ChkUseCertEndpoint_CheckedChanged(object sender, EventArgs e)
        {
            SetEndpoints();
        }

        private void SetEndpoints()
        {
            string strCert = "";
            if (ChkUseCertEndpoint.Checked)
                strCert = ".cert";
            //Manage Cert endpoints

            if (CboPTLSVersion.Text == "1.17.18")
            {
                _svcInfo = @"https://api.cert.nabcommerce.com/REST/2.0.18/SvcInfo";
                _txn = @"https://api.cert.nabcommerce.com/REST/2.0.18/Txn";
            }
            else
            {
                MessageBox.Show(
                    "Previous CWS releases not supported as enumerated values changed from index to actual value with 1.17.18 release");
            }
        }

        #region Setup Help Links

        private void lnkSignOnWithToken_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://commercelab.ipcommerce.com/Docs/1.17.13/CWS_REST_Developer_Guide/RESTImplementation/PreparingTheAppToTransact/SignOnAuthentication/SignOnWithToken.aspx");
        }

        private void lnkManageApplicationData_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://commercelab.ipcommerce.com/Docs/1.17.13/CWS_REST_Developer_Guide/RESTImplementation/PreparingTheAppToTransact/ManagingAppConfigData/index.aspx");
        }

        private void lnkRetrieveServiceInformation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://commercelab.ipcommerce.com/Docs/1.17.13/CWS_REST_Developer_Guide/RESTImplementation/PreparingTheAppToTransact/RetrievingServiceInformation.aspx");
        }

        private void lnkMoreAboutREST_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://commercelab.ipcommerce.com/Docs/1.17.13/CWS_REST_Developer_Guide/Introduction.aspx");
        }

        private void lnkManageMerchantProfiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(
                "http://commercelab.ipcommerce.com/Docs/1.17.13/CWS_REST_Developer_Guide/RESTImplementation/PreparingTheAppToTransact/ManagingMerchantProfiles/index.aspx");
        }

        #endregion Setup Help Links

        private void txtRequest_KeyDown(object sender, KeyEventArgs e)
        {
            // See if Ctrl-A is pressed... 
            if (e.Control && (e.KeyCode == Keys.A))
            {
                txtRequest.SelectAll();
                e.Handled = true;
            }
        }

        private void txtResponse_KeyDown(object sender, KeyEventArgs e)
        {
            // See if Ctrl-A is pressed... 
            if (e.Control && (e.KeyCode == Keys.A))
            {
                txtResponse.SelectAll();
                e.Handled = true;
            }
        }

        public class item
        {
            public string Name;
            public string Value;

            public item(string name, string value)
            {
                Name = name;
                Value = value;
            }

            public override string ToString()
            {
                // Generates the text shown in the combo box
                return Name;
            }
        }

        public enum TransactionType : int
        {
            [System.Runtime.Serialization.EnumMemberAttribute()]
            AuthorizeAndCapture = 0,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Authorize = 1,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Capture = 2,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            CaptureAll = 3,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            CaptureSelective = 4,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            ReturnById = 5,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            ReturnUnlinked = 6,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Adjust = 7,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Undo = 8,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            QueryAccount = 9,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            Verify = 10,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            CaptureAllAsync = 11,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            CaptureSelectiveAsync = 12,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            ManageAccount = 13,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            ManageAccountById = 14,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            QueryBatch = 15,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            QueryTransactionsSummary = 16,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            QueryTransactionsFamilies = 17,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            QueryTransactionsDetail = 18,
            [System.Runtime.Serialization.EnumMemberAttribute()]
            NotSet = 19
        }

        public class response
        {
            public TransactionType TransactionType;
            public string Status;
            public string StatusCode;
            public string StatusMessage;
            public string TransactionId;
            public string OriginatorTransactionId;
            public string ServiceTransactionId;
            public string CaptureState;
            public string TransactionState;
            public string Amount;
            public string CardType;
            public string FeeAmount;
            public string ApprovalCode;
            public string AVSResult;
            public string BatchId;
            public string CVResult;
            public string CardLevel;
            public string DowngradeCode;
            public string MaskedPAN;
            public string PaymentAccountDataToken;
            public string RetrievalReferenceNumber;
            public string Resubmit;
            public string SettlementDate;
            public string FinalBalance;
            public string OrderId;
            public string CashBackAmount;
            public string AdviceResponse;
            public string CommercialCardResponse;
            public string ReturnedACI;

            public response(TransactionType transactionType, string status, string statusCode, string statusMessage,
                            string transactionId, string originatorTransactionId, string serviceTransactionId,
                            string captureState, string transactionState, string amount, string cardType,
                            string feeAmount, string approvalCode,
                            string aVSResult, string batchId, string cVResult, string cardLevel, string downgradeCode,
                            string maskedPAN,
                            string paymentAccountDataToken, string retrievalReferenceNumber, string resubmit,
                            string settlementDate, string finalBalance, string orderId,
                            string cashBackAmount, string adviceResponse, string commercialCardResponse,
                            string returnedACI)
            {
                TransactionType = transactionType;
                Status = status;
                StatusCode = statusCode;
                StatusMessage = statusMessage;
                TransactionId = transactionId;
                OriginatorTransactionId = originatorTransactionId;
                ServiceTransactionId = serviceTransactionId;
                CaptureState = captureState;
                TransactionState = transactionState;
                Amount = amount;
                CardType = cardType;
                FeeAmount = feeAmount;
                ApprovalCode = approvalCode;
                AVSResult = aVSResult;
                BatchId = batchId;
                CVResult = cVResult;
                CardLevel = cardLevel;
                DowngradeCode = downgradeCode;
                MaskedPAN = maskedPAN;
                PaymentAccountDataToken = paymentAccountDataToken;
                RetrievalReferenceNumber = retrievalReferenceNumber;
                Resubmit = resubmit;
                SettlementDate = settlementDate;
                FinalBalance = finalBalance;
                OrderId = orderId;
                CashBackAmount = cashBackAmount;
                AdviceResponse = adviceResponse;
                CommercialCardResponse = commercialCardResponse;
                ReturnedACI = returnedACI;
            }
        }

        public class IndustryTypeValues
        {
            //ApplicationData
            public string ApplicationAttended;
            public string ApplicationLocation;
            public string PINCapability;
            public string ReadCapability;

            //MerchantData
            public string IndustryType;
            public string CustomerPresent;
            public string EntryMode;

            public IndustryTypeValues(string applicationAttended, string applicationLocation, string pINCapability,
                string readCapability, string industryType, string customerPresent, string entryMode)
            {
                ApplicationAttended = applicationAttended;
                ApplicationLocation = applicationLocation;
                PINCapability = pINCapability;
                ReadCapability = readCapability;
                IndustryType = industryType;
                CustomerPresent = customerPresent;
                EntryMode = entryMode;
            }
        }
    }
}