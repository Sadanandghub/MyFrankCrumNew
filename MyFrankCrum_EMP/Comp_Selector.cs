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
    ///The Comp_Selector recording.
    /// </summary>
    [TestModule("08404687-1bf3-4ad5-b53e-becdc510a179", ModuleType.Recording, 1)]
    public partial class Comp_Selector : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Comp_Selector instance = new Comp_Selector();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Comp_Selector()
        {
            CompName = "A0f21";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Comp_Selector Instance
        {
            get { return instance; }
        }

#region Variables

        string _CompName;

        /// <summary>
        /// Gets or sets the value of variable CompName.
        /// </summary>
        [TestVariable("5ac666fd-4de1-4e60-8c76-7b15e63726f4")]
        public string CompName
        {
            get { return _CompName; }
            set { _CompName = value; }
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

            // Company Selector
            Report.Log(ReportLevel.Info, "Section", "Company Selector", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.Text' at Center.", repo.MyFrankCrum.TextInfo, new RecordItemIndex(1));
            repo.MyFrankCrum.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.Text' at Center.", repo.MyFrankCrum.TextInfo, new RecordItemIndex(2));
            repo.MyFrankCrum.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CompName' with focus on 'MyFrankCrum.Text'.", repo.MyFrankCrum.TextInfo, new RecordItemIndex(3));
            repo.MyFrankCrum.Text.PressKeys(CompName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.A0F21THSNATIONALLLC' at Center.", repo.MyFrankCrum.A0F21THSNATIONALLLCInfo, new RecordItemIndex(4));
            repo.MyFrankCrum.A0F21THSNATIONALLLC.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
