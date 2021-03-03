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
    ///The EmployeeSelection recording.
    /// </summary>
    [TestModule("677c1db2-2d99-4d44-ab6f-39c53e5498b2", ModuleType.Recording, 1)]
    public partial class EmployeeSelection : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static EmployeeSelection instance = new EmployeeSelection();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EmployeeSelection()
        {
            Emp = "-1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EmployeeSelection Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable EmpName.
        /// </summary>
        [TestVariable("63421979-03c2-4681-8118-3604485e880a")]
        public string EmpName
        {
            get { return repo.EmpName; }
            set { repo.EmpName = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Emp.
        /// </summary>
        [TestVariable("e16f1db2-14e4-4041-be28-46a2da27e7ee")]
        public string Emp
        {
            get { return repo.Emp; }
            set { repo.Emp = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.selectEmp' at Center.", repo.ApplicationUnderTest.SomeDivTag.selectEmpInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.SomeDivTag.selectEmp.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}