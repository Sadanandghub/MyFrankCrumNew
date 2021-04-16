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
    ///The TerminateActiveEmployee recording.
    /// </summary>
    [TestModule("67ee5bc9-5812-4da3-9927-c0de11f1e6fe", ModuleType.Recording, 1)]
    public partial class TerminateActiveEmployee : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static TerminateActiveEmployee instance = new TerminateActiveEmployee();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TerminateActiveEmployee()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TerminateActiveEmployee Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable TermReasonValue.
        /// </summary>
        [TestVariable("4a796e37-36e6-40be-9cbb-afbecd29fb31")]
        public string TermReasonValue
        {
            get { return repo.TermReasonValue; }
            set { repo.TermReasonValue = value; }
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

            Report.Screenshot(ReportLevel.Info, "User", "Emp Count before done Inactive Employee", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.GrayBox' at Center.", repo.ApplicationUnderTest.SomeDivTag.GrayBoxInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.SomeDivTag.GrayBox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TerminateClick' at Center.", repo.ApplicationUnderTest.TerminateClickInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.TerminateClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(3));
            Delay.Duration(10000, false);
            
            // Enter the required data
            Report.Log(ReportLevel.Info, "Section", "Enter the required data", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TerminateDate' at Center.", repo.ApplicationUnderTest.TerminateDateInfo, new RecordItemIndex(5));
            repo.ApplicationUnderTest.TerminateDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04/01/2021' with focus on 'ApplicationUnderTest.TerminateDate'.", repo.ApplicationUnderTest.TerminateDateInfo, new RecordItemIndex(6));
            repo.ApplicationUnderTest.TerminateDate.PressKeys("04/01/2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(7));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LastDayWorked' at Center.", repo.LastDayWorkedInfo, new RecordItemIndex(8));
            repo.LastDayWorked.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TermiLastWorkDate' at Center.", repo.ApplicationUnderTest.TermiLastWorkDateInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.TermiLastWorkDate.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04/03/2021' with focus on 'ApplicationUnderTest.TermiLastWorkDate'.", repo.ApplicationUnderTest.TermiLastWorkDateInfo, new RecordItemIndex(10));
            //repo.ApplicationUnderTest.TermiLastWorkDate.PressKeys("04/03/2021");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '04/03/2021' on item 'ApplicationUnderTest.TermiLastWorkDate'.", repo.ApplicationUnderTest.TermiLastWorkDateInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.TermiLastWorkDate.Element.SetAttributeValue("Value", "04/03/2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TermiPayThrough' at Center.", repo.ApplicationUnderTest.TermiPayThroughInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.TermiPayThrough.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04/03/2021' with focus on 'ApplicationUnderTest.TermiPayThrough'.", repo.ApplicationUnderTest.TermiPayThroughInfo, new RecordItemIndex(13));
            //repo.ApplicationUnderTest.TermiPayThrough.PressKeys("04/03/2021");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '04/04/2021' on item 'ApplicationUnderTest.TermiPayThrough'.", repo.ApplicationUnderTest.TermiPayThroughInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.TermiPayThrough.Element.SetAttributeValue("Value", "04/04/2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TermReasonClick' at Center.", repo.ApplicationUnderTest.TermReasonClickInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.TermReasonClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TermReasonValue' at Center.", repo.ApplicationUnderTest.TermReasonValueInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.TermReasonValue.Click();
            Delay.Milliseconds(0);
            
            // Press the Cancel button
            Report.Log(ReportLevel.Info, "Section", "Press the Cancel button", new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TermCancelbtn' at Center.", repo.TermCancelbtnInfo, new RecordItemIndex(18));
            repo.TermCancelbtn.Click();
            Delay.Milliseconds(0);
            
            // On an employee row click "Terminate Employee" in the right menu
            Report.Log(ReportLevel.Info, "Section", "On an employee row click \"Terminate Employee\" in the right menu", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.GrayBox' at Center.", repo.ApplicationUnderTest.SomeDivTag.GrayBoxInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.SomeDivTag.GrayBox.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TerminateClick' at Center.", repo.ApplicationUnderTest.TerminateClickInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.TerminateClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(22));
            Delay.Duration(10000, false);
            
            // Enter the required data
            Report.Log(ReportLevel.Info, "Section", "Enter the required data", new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TerminateDate' at Center.", repo.ApplicationUnderTest.TerminateDateInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.TerminateDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04/01/2021' with focus on 'ApplicationUnderTest.TerminateDate'.", repo.ApplicationUnderTest.TerminateDateInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.TerminateDate.PressKeys("04/01/2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(26));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LastDayWorked' at Center.", repo.LastDayWorkedInfo, new RecordItemIndex(27));
            repo.LastDayWorked.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TermiLastWorkDate' at Center.", repo.ApplicationUnderTest.TermiLastWorkDateInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.TermiLastWorkDate.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04/03/2021' with focus on 'ApplicationUnderTest.TermiLastWorkDate'.", repo.ApplicationUnderTest.TermiLastWorkDateInfo, new RecordItemIndex(29));
            //repo.ApplicationUnderTest.TermiLastWorkDate.PressKeys("04/03/2021");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '04/03/2021' on item 'ApplicationUnderTest.TermiLastWorkDate'.", repo.ApplicationUnderTest.TermiLastWorkDateInfo, new RecordItemIndex(30));
            repo.ApplicationUnderTest.TermiLastWorkDate.Element.SetAttributeValue("Value", "04/03/2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TermiPayThrough' at Center.", repo.ApplicationUnderTest.TermiPayThroughInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.TermiPayThrough.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '04/03/2021' with focus on 'ApplicationUnderTest.TermiPayThrough'.", repo.ApplicationUnderTest.TermiPayThroughInfo, new RecordItemIndex(32));
            //repo.ApplicationUnderTest.TermiPayThrough.PressKeys("04/03/2021");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '04/04/2021' on item 'ApplicationUnderTest.TermiPayThrough'.", repo.ApplicationUnderTest.TermiPayThroughInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.TermiPayThrough.Element.SetAttributeValue("Value", "04/04/2021");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TermReasonClick' at Center.", repo.ApplicationUnderTest.TermReasonClickInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.TermReasonClick.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.TermReasonValue' at Center.", repo.ApplicationUnderTest.TermReasonValueInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.TermReasonValue.Click();
            Delay.Milliseconds(0);
            
            // Press the Terminate button
            Report.Log(ReportLevel.Info, "Section", "Press the Terminate button", new RecordItemIndex(36));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Terminatebtn' at Center.", repo.TerminatebtnInfo, new RecordItemIndex(37));
            repo.Terminatebtn.Click();
            Delay.Milliseconds(0);
            
            // Press Yes, Terminate
            Report.Log(ReportLevel.Info, "Section", "Press Yes, Terminate", new RecordItemIndex(38));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'TerminateYesbtn' at Center.", repo.TerminateYesbtnInfo, new RecordItemIndex(39));
            repo.TerminateYesbtn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(40));
            Delay.Duration(5000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "Emp Count After done Inactive Employee", repo.ApplicationUnderTest.Self, false, new RecordItemIndex(41));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}