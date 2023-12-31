﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace Chrome_Test.Recordings
{
    public partial class Validation
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void Get_value_search_result_textbox1(RepoItemInfo textareatagInfo)
        {
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'textareatagInfo' and assigning its value to variable 'return_value'.", textareatagInfo);
            return_value = textareatagInfo.FindAdapter<TextAreaTag>().Element.GetAttributeValueText("InnerText");
        }
        
        public void Validate_search_result_textbox1(RepoItemInfo textareatagInfo)
        {
            Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=$search_result) on item 'textareatagInfo'.", textareatagInfo);
            Validate.AreEqual(return_value.ToUpper(), search_result.ToUpper(), null, false);
        }




    }
}
