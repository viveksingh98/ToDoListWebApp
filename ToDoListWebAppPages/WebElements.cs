using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListWebAppPages
{
    public static class PageWebElements
    {
        public static string uRL = "https://todomvc.com/examples/angular2/";
        public static string toDoPageTitle = "//head/title";
        public static string toDosHeader = "//todo-app/section/header/h1";
        public static string whatNeedsToBeDoneTextControl = "//section/header/input";
        public static string samSacconeLinkText = "Sam Saccone";
        public static string colinEberhardt = "//a[contains(text(),'Colin Eberhardt')]";
        public static string angular2LinkText = "Angular2";
        public static string toDoLinkText = "TodoMVC";
        public static string doubleClickText = "//footer/p[1]";
        public static string toDoCount = "//span[@class='todo-count']/strong";
        public static string yogaClassToggle = "//*[contains(text(),'Yoga Class')]/preceding-sibling::input[@class='toggle']";
        public static string clearCompletedButton = "//*[contains(text(),'Clear completed')]";
        public static string yogaClassText = "//*[contains(text(),'Yoga Class')]";
        public static string xButtonYogaClass = "//*[contains(text(),'Yoga Class')]/following-sibling::button";
        public static string specialCharacter = "//*[contains(text(),'#$%^%^##&^*^&*')]";
        public static string CharData100 = "//*[contains(text(),'dknadsfhoasdasdjpajdk;ajsdlkahlisdhalksdklqelrkqbwklelkdnlkasndl;asndkasldnkasasdbaksjddasdbjkasdfg')]";
        public static string li = "//li/div/label";
        public static string li1 = "//li[1]/div/label";
        public static string li2 = "//li[2]/div/label";
        public static string li3 = "//li[3]/div/label";
        public static string editableBox = "//todo-app/section/section/ul/li/input";



    }
}
