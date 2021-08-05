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
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyFrankCrum_EMP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Documents recording.
    /// </summary>
    [TestModule("79668db1-b320-4edb-b260-5cfc7bf64d78", ModuleType.Recording, 1)]
    public partial class Documents : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Documents instance = new Documents();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Documents()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Documents Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable RepoURL.
        /// </summary>
        [TestVariable("c75816bd-3150-4b49-aa6d-f8479454f515")]
        public string RepoURL
        {
            get { return repo.RepoURL; }
            set { repo.RepoURL = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable DocumentCategoryValue.
        /// </summary>
        [TestVariable("f25e8f2a-0b5c-4fb3-9630-41c8872a54ed")]
        public string DocumentCategoryValue
        {
            get { return repo.DocumentCategoryValue; }
            set { repo.DocumentCategoryValue = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Documents' at Center.", repo.ApplicationUnderTest.DocumentsInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.Documents.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(1));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UploadNewDocument' at Center.", repo.ApplicationUnderTest.UploadNewDocumentInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.UploadNewDocument.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentCategoryDropclick' at Center.", repo.ApplicationUnderTest.DocumentCategoryDropclickInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.DocumentCategoryDropclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentCategoryValue' at Center.", repo.ApplicationUnderTest.DocumentCategoryValueInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.DocumentCategoryValue.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentTitleClick' at Center.", repo.ApplicationUnderTest.DocumentTitleClickInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.DocumentTitleClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'DocumentNAme' with focus on 'ApplicationUnderTest.DocumentTitleClick'.", repo.ApplicationUnderTest.DocumentTitleClickInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.DocumentTitleClick.PressKeys("DocumentNAme");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentExpiresDate' at Center.", repo.ApplicationUnderTest.DocumentExpiresDateInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.DocumentExpiresDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '05/18/2021' with focus on 'ApplicationUnderTest.DocumentExpiresDate'.", repo.ApplicationUnderTest.DocumentExpiresDateInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.DocumentExpiresDate.PressKeys("05/18/2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentFileEmployeeCanView' at Center.", repo.ApplicationUnderTest.DocumentFileEmployeeCanViewInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.DocumentFileEmployeeCanView.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentChooseFile' at Center.", repo.ApplicationUnderTest.DocumentChooseFileInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.DocumentChooseFile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SystemItemNameDisplay' at Center.", repo.Open.SystemItemNameDisplayInfo, new RecordItemIndex(11));
            repo.Open.SystemItemNameDisplay.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(12));
            repo.Open.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentUpload' at Center.", repo.ApplicationUnderTest.DocumentUploadInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.DocumentUpload.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(14));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(15));
            
            // Fill out the dialog fields but select an invalid file type and press the Upload button
            Report.Log(ReportLevel.Info, "Section", "Fill out the dialog fields but select an invalid file type and press the Upload button", new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.UploadNewDocument' at Center.", repo.ApplicationUnderTest.UploadNewDocumentInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.UploadNewDocument.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentCategoryDropclick' at Center.", repo.ApplicationUnderTest.DocumentCategoryDropclickInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.DocumentCategoryDropclick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentCategoryValue' at Center.", repo.ApplicationUnderTest.DocumentCategoryValueInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.DocumentCategoryValue.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentTitleClick' at Center.", repo.ApplicationUnderTest.DocumentTitleClickInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.DocumentTitleClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'DocumentNAme' with focus on 'ApplicationUnderTest.DocumentTitleClick'.", repo.ApplicationUnderTest.DocumentTitleClickInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.DocumentTitleClick.PressKeys("DocumentNAme");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentExpiresDate' at Center.", repo.ApplicationUnderTest.DocumentExpiresDateInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.DocumentExpiresDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '05/18/2021' with focus on 'ApplicationUnderTest.DocumentExpiresDate'.", repo.ApplicationUnderTest.DocumentExpiresDateInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.DocumentExpiresDate.PressKeys("05/18/2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentFileEmployeeCanView' at Center.", repo.ApplicationUnderTest.DocumentFileEmployeeCanViewInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.DocumentFileEmployeeCanView.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentChooseFile' at Center.", repo.ApplicationUnderTest.DocumentChooseFileInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.DocumentChooseFile.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SystemItemNameDisplay1' at Center.", repo.Open.SystemItemNameDisplay1Info, new RecordItemIndex(26));
            repo.Open.SystemItemNameDisplay1.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SystemItemNameDisplay' at Center.", repo.Open.SystemItemNameDisplayInfo, new RecordItemIndex(27));
            //repo.Open.SystemItemNameDisplay.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(28));
            repo.Open.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentUpload' at Center.", repo.ApplicationUnderTest.DocumentUploadInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.DocumentUpload.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ApplicationUnderTest.AlertErrorErrorSectionWrapper'.", repo.ApplicationUnderTest.AlertErrorErrorSectionWrapperInfo, new RecordItemIndex(30));
            Validate.Exists(repo.ApplicationUnderTest.AlertErrorErrorSectionWrapperInfo);
            Delay.Milliseconds(100);
            
            // Press the Download menu option on the right of the document row
            Report.Log(ReportLevel.Info, "Section", "Press the Download menu option on the right of the document row", new RecordItemIndex(31));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton' at Center.", repo.ApplicationUnderTest.DropdownMenuButtonInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.DropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentDownload' at Center.", repo.ApplicationUnderTest.DocumentDownloadInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.DocumentDownload.Click();
            Delay.Milliseconds(0);
            
            // The document is deleted **suggesting we add confirmation before deleting**
            Report.Log(ReportLevel.Info, "Section", "The document is deleted **suggesting we add confirmation before deleting**", new RecordItemIndex(34));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DropdownMenuButton' at Center.", repo.ApplicationUnderTest.DropdownMenuButtonInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.DropdownMenuButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentDelete' at Center.", repo.ApplicationUnderTest.DocumentDeleteInfo, new RecordItemIndex(36));
            repo.ApplicationUnderTest.DocumentDelete.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(37));
            Delay.Duration(3000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Screenshot Taken", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(38));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DocumentDelete1' at Center.", repo.ApplicationUnderTest.DocumentDelete1Info, new RecordItemIndex(39));
            repo.ApplicationUnderTest.DocumentDelete1.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
