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
    ///The Employment_Forms recording.
    /// </summary>
    [TestModule("910672e6-3bdd-43cc-9bef-d38f3c621b8a", ModuleType.Recording, 1)]
    public partial class Employment_Forms : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Employment_Forms instance = new Employment_Forms();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Employment_Forms()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Employment_Forms Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EmployeementChooseFile' at Center.", repo.ApplicationUnderTest.EmployeementChooseFileInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.EmployeementChooseFile.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.SystemItemNameDisplay2' at Center.", repo.Open.SystemItemNameDisplay2Info, new RecordItemIndex(1));
            //repo.Open.SystemItemNameDisplay2.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(2));
            //repo.Open.ButtonOpen.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Text1148' at Center.", repo.Open.Text1148Info, new RecordItemIndex(3));
            repo.Open.Text1148.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'QDC_FWCI_Q-117097_34823_GL_ACCEPTED03182021_03212321_AM' with focus on 'Open.Text1148'.", repo.Open.Text1148Info, new RecordItemIndex(4));
            repo.Open.Text1148.PressKeys("QDC_FWCI_Q-117097_34823_GL_ACCEPTED03182021_03212321_AM");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(6));
            repo.Open.ButtonOpen.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(7));
            //Delay.Duration(300, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EmployeementChooseFile1' at Center.", repo.ApplicationUnderTest.EmployeementChooseFile1Info, new RecordItemIndex(8));
            //repo.ApplicationUnderTest.EmployeementChooseFile1.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Text1148' at Center.", repo.Open.Text1148Info, new RecordItemIndex(9));
            //repo.Open.Text1148.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '117097_34823_GL_ACCEPTED03182021_03212321_AM' with focus on 'Open.Text1148'.", repo.Open.Text1148Info, new RecordItemIndex(10));
            //repo.Open.Text1148.PressKeys("117097_34823_GL_ACCEPTED03182021_03212321_AM");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(11));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(12));
            //repo.Open.ButtonOpen.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EmployeementChooseFile2' at Center.", repo.ApplicationUnderTest.EmployeementChooseFile2Info, new RecordItemIndex(13));
            //repo.ApplicationUnderTest.EmployeementChooseFile2.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.Text1148' at Center.", repo.Open.Text1148Info, new RecordItemIndex(14));
            //repo.Open.Text1148.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '117097_34823_GL_ACCEPTED03182021_03212321_AM' with focus on 'Open.Text1148'.", repo.Open.Text1148Info, new RecordItemIndex(15));
            //repo.Open.Text1148.PressKeys("117097_34823_GL_ACCEPTED03182021_03212321_AM");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(16));
            //Delay.Duration(3000, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Open.ButtonOpen' at Center.", repo.Open.ButtonOpenInfo, new RecordItemIndex(17));
            //repo.Open.ButtonOpen.Click();
            //Delay.Milliseconds(0);
            
            Mouse_Click_DeductionNext(repo.ApplicationUnderTest.EmployeeFormNextInfo);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
