/* ***************************************************************
* Test Automation Framework - Data Model
* Author: Vivek Singh
* Date/Time: 06/24/2022
*****************************************************************/

using System;
using System.Xml.Serialization;

namespace ToDoListWebAppData
{
    [Serializable()]
    [XmlRoot("Root")]
    public class WhatNeedsToBeDoneInputData
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class Root
        {

            private RootWhatNeedsToBeDone[] toDoTextBoxField;

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("WhatNeedsToBeDone", IsNullable = false)]
            public RootWhatNeedsToBeDone[] ToDoTextBox
            {
                get
                {
                    return this.toDoTextBoxField;
                }
                set
                {
                    this.toDoTextBoxField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class RootWhatNeedsToBeDone
        {

            private string textField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string Text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }
        }


    }
}
