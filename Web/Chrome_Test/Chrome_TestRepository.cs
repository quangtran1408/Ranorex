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

namespace Chrome_Test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Chrome_TestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("b95a0521-1a6a-49fe-a98f-206201c64030")]
    public partial class Chrome_TestRepository : RepoGenBaseFolder
    {
        static Chrome_TestRepository instance = new Chrome_TestRepository();
        Chrome_TestRepositoryFolders.Search_Result_windowAppFolder _search_result_window;
        Chrome_TestRepositoryFolders.GoogleChrome_windowAppFolder _googlechrome_window;
        Chrome_TestRepositoryFolders.Chrome_windowAppFolder _chrome_window;

        /// <summary>
        /// Gets the singleton class instance representing the Chrome_TestRepository element repository.
        /// </summary>
        [RepositoryFolder("b95a0521-1a6a-49fe-a98f-206201c64030")]
        public static Chrome_TestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Chrome_TestRepository() 
            : base("Chrome_TestRepository", "/", null, 0, false, "b95a0521-1a6a-49fe-a98f-206201c64030", ".\\RepositoryImages\\Chrome_TestRepositoryb95a0521.rximgres")
        {
            _search_result_window = new Chrome_TestRepositoryFolders.Search_Result_windowAppFolder(this);
            _googlechrome_window = new Chrome_TestRepositoryFolders.GoogleChrome_windowAppFolder(this);
            _chrome_window = new Chrome_TestRepositoryFolders.Chrome_windowAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("b95a0521-1a6a-49fe-a98f-206201c64030")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Search_Result_window folder.
        /// </summary>
        [RepositoryFolder("f0a492e7-2378-419b-a69f-ca6584a08e38")]
        public virtual Chrome_TestRepositoryFolders.Search_Result_windowAppFolder Search_Result_window
        {
            get { return _search_result_window; }
        }

        /// <summary>
        /// The GoogleChrome_window folder.
        /// </summary>
        [RepositoryFolder("d19f7605-fe3b-4918-be68-3a7bb2dded8e")]
        public virtual Chrome_TestRepositoryFolders.GoogleChrome_windowAppFolder GoogleChrome_window
        {
            get { return _googlechrome_window; }
        }

        /// <summary>
        /// The Chrome_window folder.
        /// </summary>
        [RepositoryFolder("a155b99a-4dc4-400a-82af-16e9dbc48fe5")]
        public virtual Chrome_TestRepositoryFolders.Chrome_windowAppFolder Chrome_window
        {
            get { return _chrome_window; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Chrome_TestRepositoryFolders
    {
        /// <summary>
        /// The Search_Result_windowAppFolder folder.
        /// </summary>
        [RepositoryFolder("f0a492e7-2378-419b-a69f-ca6584a08e38")]
        public partial class Search_Result_windowAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _search_result_textboxInfo;

            /// <summary>
            /// Creates a new Search_Result_window  folder.
            /// </summary>
            public Search_Result_windowAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Search_Result_window", "/dom[@browsername='Chrome']", parentFolder, 5000, null, false, "f0a492e7-2378-419b-a69f-ca6584a08e38", "")
            {
                _search_result_textboxInfo = new RepoItemInfo(this, "search_result_textbox", ".//textarea[#'APjFqb']", "", 5000, null, "5a163ad0-2bf8-4128-af81-ebce78a2a2cb");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f0a492e7-2378-419b-a69f-ca6584a08e38")]
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
            [RepositoryItemInfo("f0a492e7-2378-419b-a69f-ca6584a08e38")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The search_result_textbox item.
            /// </summary>
            [RepositoryItem("5a163ad0-2bf8-4128-af81-ebce78a2a2cb")]
            public virtual Ranorex.TextAreaTag search_result_textbox
            {
                get
                {
                    return _search_result_textboxInfo.CreateAdapter<Ranorex.TextAreaTag>(true);
                }
            }

            /// <summary>
            /// The search_result_textbox item info.
            /// </summary>
            [RepositoryItemInfo("5a163ad0-2bf8-4128-af81-ebce78a2a2cb")]
            public virtual RepoItemInfo search_result_textboxInfo
            {
                get
                {
                    return _search_result_textboxInfo;
                }
            }
        }

        /// <summary>
        /// The GoogleChrome_windowAppFolder folder.
        /// </summary>
        [RepositoryFolder("d19f7605-fe3b-4918-be68-3a7bb2dded8e")]
        public partial class GoogleChrome_windowAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _address_textboxInfo;
            RepoItemInfo _back_buttonInfo;

            /// <summary>
            /// Creates a new GoogleChrome_window  folder.
            /// </summary>
            public GoogleChrome_windowAppFolder(RepoGenBaseFolder parentFolder) :
                    base("GoogleChrome_window", "/form[@title='Google - Google Chrome']", parentFolder, 5000, null, true, "d19f7605-fe3b-4918-be68-3a7bb2dded8e", "")
            {
                _address_textboxInfo = new RepoItemInfo(this, "address_textbox", "container[@accessiblename='Google - Google Chrome']/container/container[@accessiblerole='Pane']/container[2]/container[1]/toolbar[@accessiblerole='ToolBar']/?/?/container[@accessiblerole='Grouping']/text[@accessiblename='Address and search bar']", "", 5000, null, "5bfabb3c-57e5-4373-ae12-ab99198c79f4");
                _back_buttonInfo = new RepoItemInfo(this, "back_button", ".//toolbar[@accessiblerole='ToolBar']//button[@accessiblename='Back']", "element", 5000, null, "521f5d82-d28d-470f-9a52-ac9deef1c93a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d19f7605-fe3b-4918-be68-3a7bb2dded8e")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d19f7605-fe3b-4918-be68-3a7bb2dded8e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The address_textbox item.
            /// </summary>
            [RepositoryItem("5bfabb3c-57e5-4373-ae12-ab99198c79f4")]
            public virtual Ranorex.Text address_textbox
            {
                get
                {
                    return _address_textboxInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The address_textbox item info.
            /// </summary>
            [RepositoryItemInfo("5bfabb3c-57e5-4373-ae12-ab99198c79f4")]
            public virtual RepoItemInfo address_textboxInfo
            {
                get
                {
                    return _address_textboxInfo;
                }
            }

            /// <summary>
            /// The back_button item.
            /// </summary>
            [RepositoryItem("521f5d82-d28d-470f-9a52-ac9deef1c93a")]
            public virtual Ranorex.Button back_button
            {
                get
                {
                    return _back_buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The back_button item info.
            /// </summary>
            [RepositoryItemInfo("521f5d82-d28d-470f-9a52-ac9deef1c93a")]
            public virtual RepoItemInfo back_buttonInfo
            {
                get
                {
                    return _back_buttonInfo;
                }
            }
        }

        /// <summary>
        /// The Chrome_windowAppFolder folder.
        /// </summary>
        [RepositoryFolder("a155b99a-4dc4-400a-82af-16e9dbc48fe5")]
        public partial class Chrome_windowAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new Chrome_window  folder.
            /// </summary>
            public Chrome_windowAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Chrome_window", "/dom[@browsername='Chrome']", parentFolder, 30000, null, false, "a155b99a-4dc4-400a-82af-16e9dbc48fe5", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a155b99a-4dc4-400a-82af-16e9dbc48fe5")]
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
            [RepositoryItemInfo("a155b99a-4dc4-400a-82af-16e9dbc48fe5")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
