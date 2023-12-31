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

namespace Excel_Test
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the Excel_TestRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("ba1ca43b-7c78-4dae-9a09-ee871d6ecb3d")]
    public partial class Excel_TestRepository : RepoGenBaseFolder
    {
        static Excel_TestRepository instance = new Excel_TestRepository();
        Excel_TestRepositoryFolders.ExcelAppFolder _excel;

        /// <summary>
        /// Gets the singleton class instance representing the Excel_TestRepository element repository.
        /// </summary>
        [RepositoryFolder("ba1ca43b-7c78-4dae-9a09-ee871d6ecb3d")]
        public static Excel_TestRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Excel_TestRepository() 
            : base("Excel_TestRepository", "/", null, 0, false, "ba1ca43b-7c78-4dae-9a09-ee871d6ecb3d", ".\\RepositoryImages\\Excel_TestRepositoryba1ca43b.rximgres")
        {
            _excel = new Excel_TestRepositoryFolders.ExcelAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("ba1ca43b-7c78-4dae-9a09-ee871d6ecb3d")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Excel folder.
        /// </summary>
        [RepositoryFolder("7b2881d2-7bb9-4376-89e6-c07ccc49ab69")]
        public virtual Excel_TestRepositoryFolders.ExcelAppFolder Excel
        {
            get { return _excel; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Excel_TestRepositoryFolders
    {
        /// <summary>
        /// The ExcelAppFolder folder.
        /// </summary>
        [RepositoryFolder("7b2881d2-7bb9-4376-89e6-c07ccc49ab69")]
        public partial class ExcelAppFolder : RepoGenBaseFolder
        {
            Excel_TestRepositoryFolders.Row1Folder _row1;
            Excel_TestRepositoryFolders.Row2Folder _row2;
            RepoItemInfo _blank_workbook_linkInfo;
            RepoItemInfo _save_buttonInfo;
            RepoItemInfo _close_buttonInfo;
            RepoItemInfo _dont_save_buttonInfo;

            /// <summary>
            /// Creates a new Excel  folder.
            /// </summary>
            public ExcelAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Excel", "/form[@processname='EXCEL']", parentFolder, 30000, null, true, "7b2881d2-7bb9-4376-89e6-c07ccc49ab69", "")
            {
                _row1 = new Excel_TestRepositoryFolders.Row1Folder(this);
                _row2 = new Excel_TestRepositoryFolders.Row2Folder(this);
                _blank_workbook_linkInfo = new RepoItemInfo(this, "blank_workbook_link", ".//link[@name='Blank workbook' and @visible='True']", "", 30000, null, "5303ade7-797a-4525-862b-7e2f6bed2255");
                _save_buttonInfo = new RepoItemInfo(this, "save_button", ".//toolbar[@name='Quick Access Toolbar']/button[@name='Save']", "", 30000, null, "dd3f099d-7259-461b-863b-ade2b553836e");
                _close_buttonInfo = new RepoItemInfo(this, "close_button", ".//button[@name='Close']", "", 30000, null, "b9d61f6e-0f6f-40e3-adfa-ebf8f2cc9ee6");
                _dont_save_buttonInfo = new RepoItemInfo(this, "dont_save_button", ".//button[@name='Don''t Save']", "", 30000, null, "3a82b265-cf9d-46ed-aff1-c3b76e12bc93");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7b2881d2-7bb9-4376-89e6-c07ccc49ab69")]
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
            [RepositoryItemInfo("7b2881d2-7bb9-4376-89e6-c07ccc49ab69")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The blank_workbook_link item.
            /// </summary>
            [RepositoryItem("5303ade7-797a-4525-862b-7e2f6bed2255")]
            public virtual Ranorex.Link blank_workbook_link
            {
                get
                {
                    return _blank_workbook_linkInfo.CreateAdapter<Ranorex.Link>(true);
                }
            }

            /// <summary>
            /// The blank_workbook_link item info.
            /// </summary>
            [RepositoryItemInfo("5303ade7-797a-4525-862b-7e2f6bed2255")]
            public virtual RepoItemInfo blank_workbook_linkInfo
            {
                get
                {
                    return _blank_workbook_linkInfo;
                }
            }

            /// <summary>
            /// The save_button item.
            /// </summary>
            [RepositoryItem("dd3f099d-7259-461b-863b-ade2b553836e")]
            public virtual Ranorex.Button save_button
            {
                get
                {
                    return _save_buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The save_button item info.
            /// </summary>
            [RepositoryItemInfo("dd3f099d-7259-461b-863b-ade2b553836e")]
            public virtual RepoItemInfo save_buttonInfo
            {
                get
                {
                    return _save_buttonInfo;
                }
            }

            /// <summary>
            /// The close_button item.
            /// </summary>
            [RepositoryItem("b9d61f6e-0f6f-40e3-adfa-ebf8f2cc9ee6")]
            public virtual Ranorex.Button close_button
            {
                get
                {
                    return _close_buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The close_button item info.
            /// </summary>
            [RepositoryItemInfo("b9d61f6e-0f6f-40e3-adfa-ebf8f2cc9ee6")]
            public virtual RepoItemInfo close_buttonInfo
            {
                get
                {
                    return _close_buttonInfo;
                }
            }

            /// <summary>
            /// The dont_save_button item.
            /// </summary>
            [RepositoryItem("3a82b265-cf9d-46ed-aff1-c3b76e12bc93")]
            public virtual Ranorex.Button dont_save_button
            {
                get
                {
                    return _dont_save_buttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The dont_save_button item info.
            /// </summary>
            [RepositoryItemInfo("3a82b265-cf9d-46ed-aff1-c3b76e12bc93")]
            public virtual RepoItemInfo dont_save_buttonInfo
            {
                get
                {
                    return _dont_save_buttonInfo;
                }
            }

            /// <summary>
            /// The Row1 folder.
            /// </summary>
            [RepositoryFolder("a778ce97-d0de-4e7a-aea3-39857cc73aeb")]
            public virtual Excel_TestRepositoryFolders.Row1Folder Row1
            {
                get { return _row1; }
            }

            /// <summary>
            /// The Row2 folder.
            /// </summary>
            [RepositoryFolder("0b536811-1e8a-4d48-bcb8-1234f1470726")]
            public virtual Excel_TestRepositoryFolders.Row2Folder Row2
            {
                get { return _row2; }
            }
        }

        /// <summary>
        /// The Row1Folder folder.
        /// </summary>
        [RepositoryFolder("a778ce97-d0de-4e7a-aea3-39857cc73aeb")]
        public partial class Row1Folder : RepoGenBaseFolder
        {
            RepoItemInfo _cella1Info;
            RepoItemInfo _cellb1Info;
            RepoItemInfo _cellc1Info;
            RepoItemInfo _celld1Info;

            /// <summary>
            /// Creates a new Row1  folder.
            /// </summary>
            public Row1Folder(RepoGenBaseFolder parentFolder) :
                    base("Row1", ".//table[@name='Sheet1']/row[@index='1']", parentFolder, 30000, null, false, "a778ce97-d0de-4e7a-aea3-39857cc73aeb", "")
            {
                _cella1Info = new RepoItemInfo(this, "CellA1", "cell[@address='A1']", "", 30000, null, "971744c2-38e1-4689-be90-8027bc4095d4");
                _cellb1Info = new RepoItemInfo(this, "CellB1", "cell[@address='B1']", "", 30000, null, "c57c6fb8-3cb9-4359-9b30-e1b902873056");
                _cellc1Info = new RepoItemInfo(this, "CellC1", "cell[@address='C1']", "", 30000, null, "0a3115b5-3697-49b0-8a2f-16550a4393bf");
                _celld1Info = new RepoItemInfo(this, "CellD1", "cell[@address='D1']", "", 30000, null, "a78e8b06-097d-4712-9714-db91e259e070");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a778ce97-d0de-4e7a-aea3-39857cc73aeb")]
            public virtual Ranorex.Row Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Row>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a778ce97-d0de-4e7a-aea3-39857cc73aeb")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The CellA1 item.
            /// </summary>
            [RepositoryItem("971744c2-38e1-4689-be90-8027bc4095d4")]
            public virtual Ranorex.Cell CellA1
            {
                get
                {
                    return _cella1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellA1 item info.
            /// </summary>
            [RepositoryItemInfo("971744c2-38e1-4689-be90-8027bc4095d4")]
            public virtual RepoItemInfo CellA1Info
            {
                get
                {
                    return _cella1Info;
                }
            }

            /// <summary>
            /// The CellB1 item.
            /// </summary>
            [RepositoryItem("c57c6fb8-3cb9-4359-9b30-e1b902873056")]
            public virtual Ranorex.Cell CellB1
            {
                get
                {
                    return _cellb1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellB1 item info.
            /// </summary>
            [RepositoryItemInfo("c57c6fb8-3cb9-4359-9b30-e1b902873056")]
            public virtual RepoItemInfo CellB1Info
            {
                get
                {
                    return _cellb1Info;
                }
            }

            /// <summary>
            /// The CellC1 item.
            /// </summary>
            [RepositoryItem("0a3115b5-3697-49b0-8a2f-16550a4393bf")]
            public virtual Ranorex.Cell CellC1
            {
                get
                {
                    return _cellc1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellC1 item info.
            /// </summary>
            [RepositoryItemInfo("0a3115b5-3697-49b0-8a2f-16550a4393bf")]
            public virtual RepoItemInfo CellC1Info
            {
                get
                {
                    return _cellc1Info;
                }
            }

            /// <summary>
            /// The CellD1 item.
            /// </summary>
            [RepositoryItem("a78e8b06-097d-4712-9714-db91e259e070")]
            public virtual Ranorex.Cell CellD1
            {
                get
                {
                    return _celld1Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellD1 item info.
            /// </summary>
            [RepositoryItemInfo("a78e8b06-097d-4712-9714-db91e259e070")]
            public virtual RepoItemInfo CellD1Info
            {
                get
                {
                    return _celld1Info;
                }
            }
        }

        /// <summary>
        /// The Row2Folder folder.
        /// </summary>
        [RepositoryFolder("0b536811-1e8a-4d48-bcb8-1234f1470726")]
        public partial class Row2Folder : RepoGenBaseFolder
        {
            RepoItemInfo _cella2Info;
            RepoItemInfo _cellb2Info;
            RepoItemInfo _cellc2Info;
            RepoItemInfo _celld2Info;

            /// <summary>
            /// Creates a new Row2  folder.
            /// </summary>
            public Row2Folder(RepoGenBaseFolder parentFolder) :
                    base("Row2", ".//table[@name='Sheet1']/row[@index='2']", parentFolder, 30000, null, false, "0b536811-1e8a-4d48-bcb8-1234f1470726", "")
            {
                _cella2Info = new RepoItemInfo(this, "CellA2", "cell[@address='A2']", "", 30000, null, "a1349048-751f-47a4-bc13-3a59048c4bb4");
                _cellb2Info = new RepoItemInfo(this, "CellB2", "cell[@address='B2']", "", 30000, null, "1598dd0e-f4e7-409a-9298-9ef042aa1da3");
                _cellc2Info = new RepoItemInfo(this, "CellC2", "cell[@address='C2']", "", 30000, null, "e0bc1be8-551d-47de-beb8-da611664e447");
                _celld2Info = new RepoItemInfo(this, "CellD2", "cell[@address='D2']", "", 30000, null, "88ec074a-90ea-4565-933a-b8a7a19f065d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("0b536811-1e8a-4d48-bcb8-1234f1470726")]
            public virtual Ranorex.Row Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Row>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("0b536811-1e8a-4d48-bcb8-1234f1470726")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The CellA2 item.
            /// </summary>
            [RepositoryItem("a1349048-751f-47a4-bc13-3a59048c4bb4")]
            public virtual Ranorex.Cell CellA2
            {
                get
                {
                    return _cella2Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellA2 item info.
            /// </summary>
            [RepositoryItemInfo("a1349048-751f-47a4-bc13-3a59048c4bb4")]
            public virtual RepoItemInfo CellA2Info
            {
                get
                {
                    return _cella2Info;
                }
            }

            /// <summary>
            /// The CellB2 item.
            /// </summary>
            [RepositoryItem("1598dd0e-f4e7-409a-9298-9ef042aa1da3")]
            public virtual Ranorex.Cell CellB2
            {
                get
                {
                    return _cellb2Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellB2 item info.
            /// </summary>
            [RepositoryItemInfo("1598dd0e-f4e7-409a-9298-9ef042aa1da3")]
            public virtual RepoItemInfo CellB2Info
            {
                get
                {
                    return _cellb2Info;
                }
            }

            /// <summary>
            /// The CellC2 item.
            /// </summary>
            [RepositoryItem("e0bc1be8-551d-47de-beb8-da611664e447")]
            public virtual Ranorex.Cell CellC2
            {
                get
                {
                    return _cellc2Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellC2 item info.
            /// </summary>
            [RepositoryItemInfo("e0bc1be8-551d-47de-beb8-da611664e447")]
            public virtual RepoItemInfo CellC2Info
            {
                get
                {
                    return _cellc2Info;
                }
            }

            /// <summary>
            /// The CellD2 item.
            /// </summary>
            [RepositoryItem("88ec074a-90ea-4565-933a-b8a7a19f065d")]
            public virtual Ranorex.Cell CellD2
            {
                get
                {
                    return _celld2Info.CreateAdapter<Ranorex.Cell>(true);
                }
            }

            /// <summary>
            /// The CellD2 item info.
            /// </summary>
            [RepositoryItemInfo("88ec074a-90ea-4565-933a-b8a7a19f065d")]
            public virtual RepoItemInfo CellD2Info
            {
                get
                {
                    return _celld2Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
