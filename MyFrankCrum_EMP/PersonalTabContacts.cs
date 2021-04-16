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
    ///The PersonalTabContacts recording.
    /// </summary>
    [TestModule("0c0609f2-ef3d-475b-b875-50dfcf762749", ModuleType.Recording, 1)]
    public partial class PersonalTabContacts : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static PersonalTabContacts instance = new PersonalTabContacts();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PersonalTabContacts()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PersonalTabContacts Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddNewContact' at Center.", repo.ApplicationUnderTest.AddNewContactInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.AddNewContact.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect' at Center.", repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelectInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Relationship' at Center.", repo.ApplicationUnderTest.RelationshipInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Relationship.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InputTagSsn' at Center.", repo.ApplicationUnderTest.InputTagSsnInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.InputTagSsn.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '234565434' with focus on 'ApplicationUnderTest.InputTagSsn'.", repo.ApplicationUnderTest.InputTagSsnInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.InputTagSsn.PressKeys("234565434");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FirstName1' at Center.", repo.ApplicationUnderTest.FirstName1Info, new RecordItemIndex(5));
            repo.ApplicationUnderTest.FirstName1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Sadanand' with focus on 'ApplicationUnderTest.FirstName1'.", repo.ApplicationUnderTest.FirstName1Info, new RecordItemIndex(6));
            repo.ApplicationUnderTest.FirstName1.PressKeys("Sadanand");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MiddleName2' at Center.", repo.ApplicationUnderTest.MiddleName2Info, new RecordItemIndex(7));
            repo.ApplicationUnderTest.MiddleName2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'L' with focus on 'ApplicationUnderTest.MiddleName2'.", repo.ApplicationUnderTest.MiddleName2Info, new RecordItemIndex(8));
            repo.ApplicationUnderTest.MiddleName2.PressKeys("L");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LastName2' at Center.", repo.ApplicationUnderTest.LastName2Info, new RecordItemIndex(9));
            repo.ApplicationUnderTest.LastName2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'GUpta' with focus on 'ApplicationUnderTest.LastName2'.", repo.ApplicationUnderTest.LastName2Info, new RecordItemIndex(10));
            repo.ApplicationUnderTest.LastName2.PressKeys("GUpta");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FormerName' at Center.", repo.ApplicationUnderTest.FormerNameInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.FormerName.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Saddu' with focus on 'ApplicationUnderTest.FormerName'.", repo.ApplicationUnderTest.FormerNameInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.FormerName.PressKeys("Saddu");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect1' at Center.", repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect1Info, new RecordItemIndex(13));
            repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactsSuffix' at Center.", repo.ApplicationUnderTest.ContactsSuffixInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.ContactsSuffix.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FaCaretDownFas3' at Center.", repo.ApplicationUnderTest.FaCaretDownFas3Info, new RecordItemIndex(15));
            repo.ApplicationUnderTest.FaCaretDownFas3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactGender' at Center.", repo.ApplicationUnderTest.ContactGenderInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.ContactGender.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BirthDate1' at Center.", repo.ApplicationUnderTest.BirthDate1Info, new RecordItemIndex(17));
            repo.ApplicationUnderTest.BirthDate1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '07101994' with focus on 'ApplicationUnderTest.BirthDate1'.", repo.ApplicationUnderTest.BirthDate1Info, new RecordItemIndex(18));
            repo.ApplicationUnderTest.BirthDate1.PressKeys("07101994");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.MarriageDate' at Center.", repo.ApplicationUnderTest.MarriageDateInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.MarriageDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0711/2019' with focus on 'ApplicationUnderTest.MarriageDate'.", repo.ApplicationUnderTest.MarriageDateInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.MarriageDate.PressKeys("0711/2019");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.DivorceDate' at Center.", repo.ApplicationUnderTest.DivorceDateInfo, new RecordItemIndex(21));
            repo.ApplicationUnderTest.DivorceDate.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '07112019' with focus on 'ApplicationUnderTest.DivorceDate'.", repo.ApplicationUnderTest.DivorceDateInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.DivorceDate.PressKeys("07112019");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactAddinfo' at Center.", repo.ApplicationUnderTest.ContactAddinfoInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.ContactAddinfo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactAdddiffer' at Center.", repo.ApplicationUnderTest.ContactAdddifferInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.ContactAdddiffer.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactAddone' at Center.", repo.ApplicationUnderTest.ContactAddoneInfo, new RecordItemIndex(25));
            repo.ApplicationUnderTest.ContactAddone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Address one' with focus on 'ApplicationUnderTest.ContactAddone'.", repo.ApplicationUnderTest.ContactAddoneInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.ContactAddone.PressKeys("Address one");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactAddtwo' at Center.", repo.ApplicationUnderTest.ContactAddtwoInfo, new RecordItemIndex(27));
            repo.ApplicationUnderTest.ContactAddtwo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Address two' with focus on 'ApplicationUnderTest.ContactAddtwo'.", repo.ApplicationUnderTest.ContactAddtwoInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.ContactAddtwo.PressKeys("Address two");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CITY3' at Center.", repo.ApplicationUnderTest.CITY3Info, new RecordItemIndex(29));
            repo.ApplicationUnderTest.CITY3.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Florida' with focus on 'ApplicationUnderTest.CITY3'.", repo.ApplicationUnderTest.CITY3Info, new RecordItemIndex(30));
            repo.ApplicationUnderTest.CITY3.PressKeys("Florida");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect2' at Center.", repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect2Info, new RecordItemIndex(31));
            repo.ApplicationUnderTest.CssKynsejIndicatorContainerMfcSelect2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactState' at Center.", repo.ApplicationUnderTest.ContactStateInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.ContactState.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.InputTagZIP' at Center.", repo.ApplicationUnderTest.InputTagZIPInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.InputTagZIP.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2345677654' with focus on 'ApplicationUnderTest.InputTagZIP'.", repo.ApplicationUnderTest.InputTagZIPInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.InputTagZIP.PressKeys("2345677654");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'HomePhone' at Center.", repo.HomePhoneInfo, new RecordItemIndex(35));
            repo.HomePhone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '5678765676' with focus on 'HomePhone'.", repo.HomePhoneInfo, new RecordItemIndex(36));
            repo.HomePhone.PressKeys("5678765676");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactWorkPhone' at Center.", repo.ApplicationUnderTest.ContactWorkPhoneInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.ContactWorkPhone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '5674567892' with focus on 'ApplicationUnderTest.ContactWorkPhone'.", repo.ApplicationUnderTest.ContactWorkPhoneInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.ContactWorkPhone.PressKeys("5674567892");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.WorkExt' at Center.", repo.ApplicationUnderTest.WorkExtInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.WorkExt.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '34' with focus on 'ApplicationUnderTest.WorkExt'.", repo.ApplicationUnderTest.WorkExtInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.WorkExt.PressKeys("34");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ContactOtherPhone' at Center.", repo.ApplicationUnderTest.ContactOtherPhoneInfo, new RecordItemIndex(41));
            repo.ApplicationUnderTest.ContactOtherPhone.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '6498765434' with focus on 'ApplicationUnderTest.ContactOtherPhone'.", repo.ApplicationUnderTest.ContactOtherPhoneInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.ContactOtherPhone.PressKeys("6498765434");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Employer' at Center.", repo.ApplicationUnderTest.EmployerInfo, new RecordItemIndex(43));
            repo.ApplicationUnderTest.Employer.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Sadanand' with focus on 'ApplicationUnderTest.Employer'.", repo.ApplicationUnderTest.EmployerInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.Employer.PressKeys("Sadanand");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Occupation' at Center.", repo.ApplicationUnderTest.OccupationInfo, new RecordItemIndex(45));
            repo.ApplicationUnderTest.Occupation.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Sales' with focus on 'ApplicationUnderTest.Occupation'.", repo.ApplicationUnderTest.OccupationInfo, new RecordItemIndex(46));
            repo.ApplicationUnderTest.Occupation.PressKeys("Sales");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='False') on item 'ApplicationUnderTest.AddContactBtn'.", repo.ApplicationUnderTest.AddContactBtnInfo, new RecordItemIndex(47));
            Validate.AttributeEqual(repo.ApplicationUnderTest.AddContactBtnInfo, "Enabled", "False");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.IsEmergencyContact' at Center.", repo.ApplicationUnderTest.IsEmergencyContactInfo, new RecordItemIndex(48));
            repo.ApplicationUnderTest.IsEmergencyContact.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'AddContactbtnTr'.", repo.AddContactbtnTrInfo, new RecordItemIndex(49));
            Validate.AttributeEqual(repo.AddContactbtnTrInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.AddContact2' at Center.", repo.ApplicationUnderTest.AddContact2Info, new RecordItemIndex(50));
            repo.ApplicationUnderTest.AddContact2.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}