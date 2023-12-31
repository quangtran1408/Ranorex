﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CRM_TestSuite
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the CRM_TestSuiteRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("51357cab-70a5-4b91-9e92-f4fc0c0999db")]
    public partial class CRM_TestSuiteRepository : RepoGenBaseFolder
    {
        static CRM_TestSuiteRepository instance = new CRM_TestSuiteRepository();
        CRM_TestSuiteRepositoryFolders.AUTAppFolder _aut;

        /// <summary>
        /// Gets the singleton class instance representing the CRM_TestSuiteRepository element repository.
        /// </summary>
        [RepositoryFolder("51357cab-70a5-4b91-9e92-f4fc0c0999db")]
        public static CRM_TestSuiteRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public CRM_TestSuiteRepository() 
            : base("CRM_TestSuiteRepository", "/", null, 0, false, "51357cab-70a5-4b91-9e92-f4fc0c0999db", ".\\RepositoryImages\\CRM_TestSuiteRepository51357cab.rximgres")
        {
            _aut = new CRM_TestSuiteRepositoryFolders.AUTAppFolder(this);
        }

#region Variables

        string _varPassword = "Lmkr0000000";

        /// <summary>
        /// Gets or sets the value of variable varPassword.
        /// </summary>
        [TestVariable("aacd678a-9832-4b0b-9eb9-fbbb0536b961")]
        public string varPassword
        {
            get { return _varPassword; }
            set { _varPassword = value; }
        }

        string _varUsername = "";

        /// <summary>
        /// Gets or sets the value of variable varUsername.
        /// </summary>
        [TestVariable("7502efb6-c801-4b46-b545-15e6d72aaf14")]
        public string varUsername
        {
            get { return _varUsername; }
            set { _varUsername = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("51357cab-70a5-4b91-9e92-f4fc0c0999db")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The AUT folder.
        /// </summary>
        [RepositoryFolder("5d12e947-ae92-4e11-8863-43d56d9297ba")]
        public virtual CRM_TestSuiteRepositoryFolders.AUTAppFolder AUT
        {
            get { return _aut; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class CRM_TestSuiteRepositoryFolders
    {
        /// <summary>
        /// The AUTAppFolder folder.
        /// </summary>
        [RepositoryFolder("5d12e947-ae92-4e11-8863-43d56d9297ba")]
        public partial class AUTAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _login_btnInfo;
            RepoItemInfo _username_tbxInfo;
            RepoItemInfo _password_tbxInfo;
            RepoItemInfo _logout_lnkInfo;

            /// <summary>
            /// Creates a new AUT  folder.
            /// </summary>
            public AUTAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AUT", "/dom[@domain='crm.logigear.com']", parentFolder, 30000, null, false, "5d12e947-ae92-4e11-8863-43d56d9297ba", "")
            {
                _login_btnInfo = new RepoItemInfo(this, "login_btn", ".//input[@type='submit']", ".//div[#'lform']/?/?/input[@type='submit']", 30000, null, "c0930ea6-9721-4f5e-837f-54c52483d1d0");
                _username_tbxInfo = new RepoItemInfo(this, "username_tbx", ".//input[@name='username']", ".//div[#'lform']/?/?/input[@name='username']", 30000, null, "2d631721-54af-4ba4-ad34-ee41c0f2514d");
                _password_tbxInfo = new RepoItemInfo(this, "password_tbx", ".//input[@name='password']", ".//div[#'lform']/?/?/input[@name='password']", 30000, null, "8c69c82d-755c-4afa-8000-69ae872eb84c");
                _logout_lnkInfo = new RepoItemInfo(this, "logout_lnk", ".//a[@innertext='Logout']", ".//div[#'container']//a[@innertext='Logout']", 30000, null, "c4de19e6-1100-4348-b3f0-bc19aa1f272d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5d12e947-ae92-4e11-8863-43d56d9297ba")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5d12e947-ae92-4e11-8863-43d56d9297ba")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The login_btn item.
            /// </summary>
            [RepositoryItem("c0930ea6-9721-4f5e-837f-54c52483d1d0")]
            public virtual Ranorex.InputTag login_btn
            {
                get
                {
                    return _login_btnInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The login_btn item info.
            /// </summary>
            [RepositoryItemInfo("c0930ea6-9721-4f5e-837f-54c52483d1d0")]
            public virtual RepoItemInfo login_btnInfo
            {
                get
                {
                    return _login_btnInfo;
                }
            }

            /// <summary>
            /// The username_tbx item.
            /// </summary>
            [RepositoryItem("2d631721-54af-4ba4-ad34-ee41c0f2514d")]
            public virtual Ranorex.InputTag username_tbx
            {
                get
                {
                    return _username_tbxInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The username_tbx item info.
            /// </summary>
            [RepositoryItemInfo("2d631721-54af-4ba4-ad34-ee41c0f2514d")]
            public virtual RepoItemInfo username_tbxInfo
            {
                get
                {
                    return _username_tbxInfo;
                }
            }

            /// <summary>
            /// The password_tbx item.
            /// </summary>
            [RepositoryItem("8c69c82d-755c-4afa-8000-69ae872eb84c")]
            public virtual Ranorex.InputTag password_tbx
            {
                get
                {
                    return _password_tbxInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The password_tbx item info.
            /// </summary>
            [RepositoryItemInfo("8c69c82d-755c-4afa-8000-69ae872eb84c")]
            public virtual RepoItemInfo password_tbxInfo
            {
                get
                {
                    return _password_tbxInfo;
                }
            }

            /// <summary>
            /// The logout_lnk item.
            /// </summary>
            [RepositoryItem("c4de19e6-1100-4348-b3f0-bc19aa1f272d")]
            public virtual Ranorex.ATag logout_lnk
            {
                get
                {
                    return _logout_lnkInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The logout_lnk item info.
            /// </summary>
            [RepositoryItemInfo("c4de19e6-1100-4348-b3f0-bc19aa1f272d")]
            public virtual RepoItemInfo logout_lnkInfo
            {
                get
                {
                    return _logout_lnkInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
