/* ***************************************************************
* Test Automation Framework - Product Model
* Author: Vivek Singh
* Date/Time: 06/24/2022
*****************************************************************/

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using ToDoListWebAppHelpers;

namespace ToDoListWebAppPages
{
    public static class ToDoMVCPage
    {
        public static IWebDriver driver;

        /// <summary>
        /// Gets the page url
        /// </summary>
        /// <returns>returns page url to the calling function</returns>
        public static string GetURL()
        {
            try
            {
                return PageWebElements.uRL;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Gets the window title
        /// </summary>
        /// <returns>returns the window title to the calling function</returns>
        public static string GetWindowTitle()
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement title = driver.FindElement(By.XPath(PageWebElements.toDoPageTitle));
                return driver.Title.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Gets the TodosMVC header
        /// </summary>
        /// <returns>return the TodosMVC header to the calling function</returns>
        public static string GetToDosHeader()
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement todosHeader = driver.FindElement(By.XPath(PageWebElements.toDosHeader));
                return todosHeader.Text.ToString();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Checks in the textbox control is visible
        /// </summary>
        /// <returns>true if successful else returns false</returns>
        public static bool WhatNeedsToBeDoneTextControlVisible()
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
                return SeleniumHelper.waitForElementIsVisible(driver, wntbdTextControl, 60);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Checks all the footer links
        /// </summary>
        /// <param name="footlinks">enum value which the particular executes the switch case</param>
        /// <returns>true if successful else returns false</returns>
        public static bool VerifyFooterLinksWorking(FooterLinks footlinks)
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement linkControl = null;
                switch (footlinks)
                {
                    case FooterLinks.SamSaccone:
                        linkControl = driver.FindElement(By.LinkText(PageWebElements.samSacconeLinkText));
                        linkControl.Click();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        if (driver.Title.ToString().Contains("Sam"))
                        {
                            return true;
                        }
                        return false;
                    case FooterLinks.ColinEberhardt:
                        linkControl = driver.FindElement(By.XPath(PageWebElements.colinEberhardt));
                        linkControl.Click();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        if (driver.Title.ToString().Contains("Colin"))
                        {
                            return true;
                        }
                        return false;
                    case FooterLinks.Angular2:
                        linkControl = driver.FindElement(By.LinkText(PageWebElements.angular2LinkText));
                        linkControl.Click();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        if (driver.Title.ToString().Contains("Angular"))
                        {
                            return true;
                        }
                        return false;
                    case FooterLinks.TodoMVC:
                        linkControl = driver.FindElement(By.LinkText(PageWebElements.toDoLinkText));
                        linkControl.Click();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                        if (driver.Title.ToString().Contains("TodoMVC"))
                        {
                            return true;
                        }
                        return false;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Enters data to the todo list by simply entering values and pressing enter key
        /// </summary>
        /// <param name="data">data list</param>
        /// <returns>true if successful else returns false</returns>
        public static bool EnterDataInToDoList(List<string> data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
                wntbdTextControl.Click();
                foreach (var item in data)
                {
                    wntbdTextControl.SendKeys(item);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    wntbdTextControl.SendKeys(Keys.Return);
                }
                IWebElement counterValue = driver.FindElement(By.XPath(PageWebElements.toDoCount));

                if (counterValue.Text.Equals("3"))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Checks if the doto counter decrements when radio button is clicked
        /// </summary>
        /// <param name="data">data list</param>
        /// <returns>true if successful else returns false</returns>
        public static bool ToDoCounterDecementsOnRadioButtonClick(List<string> data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();

                EnterDataInToDoList(data);

                IWebElement yogaToggle = driver.FindElement(By.XPath(PageWebElements.yogaClassToggle));
                yogaToggle.Click();

                IWebElement counterValue = driver.FindElement(By.XPath(PageWebElements.toDoCount));

                if (counterValue.Text.Equals("2"))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks if the todo counter increments again after toggling the strikethrough element
        /// </summary>
        /// <param name="data">data list</param>
        /// <returns>true if successful else returns false</returns>
        public static bool ToDoCounterRestoredOnRadioButtonClickAgain(List<string> data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();

                EnterDataInToDoList(data);

                IWebElement yogaToggle = driver.FindElement(By.XPath(PageWebElements.yogaClassToggle));
                yogaToggle.Click();

                IWebElement counterValue = driver.FindElement(By.XPath(PageWebElements.toDoCount));

                yogaToggle.Click();

                counterValue = driver.FindElement(By.XPath(PageWebElements.toDoCount));

                if (counterValue.Text.Equals("3"))
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data">data list</param>
        /// <returns>true if successful else returns false</returns>
        public static bool ClickClearCompletedButtonAndVerifyItemRemoved(List<string> data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();

                EnterDataInToDoList(data);
                IWebElement yogaClassElement = driver.FindElement(By.XPath(PageWebElements.yogaClassText));
                IWebElement yogaToggle = driver.FindElement(By.XPath(PageWebElements.yogaClassToggle));
                yogaToggle.Click();

                IWebElement clearCompletedButton = driver.FindElement(By.XPath(PageWebElements.clearCompletedButton));
                clearCompletedButton.Click();
                bool elementVisible;
                try
                {
                    elementVisible = SeleniumHelper.waitForElementIsVisible(driver, yogaClassElement, 3);
                }
                catch (Exception)
                {
                    return false;
                }
                return elementVisible;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks if the item gets removed when X is clicked on the list
        /// </summary>
        /// <param name="data">data list</param>
        /// <returns>true if successful else returns false</returns>
        public static bool ClickXButtonToRemoveListItem(List<string> data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();

                EnterDataInToDoList(data);
                IWebElement yogaClassElement = driver.FindElement(By.XPath(PageWebElements.yogaClassText));
                IWebElement xRemoveButton = driver.FindElement(By.XPath(PageWebElements.xButtonYogaClass));
                Actions action = new Actions(driver);
                action.MoveToElement(yogaClassElement).Perform();
                xRemoveButton.Click();
                bool elementVisible;
                try
                {
                    elementVisible = SeleniumHelper.waitForElementIsVisible(driver, yogaClassElement, 3);
                }
                catch (Exception)
                {
                    return false;
                }
                return elementVisible;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks on addition of data the counter increments
        /// </summary>
        /// <param name="data">data list</param>
        /// <returns>true if successful else returns false</returns>
        public static bool CheckTheToDoCounterIncrementOnItemAddition(List<string> data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();

                EnterDataInToDoList(data);

                EnterDataInToDoList(data);

                IWebElement counterValue = driver.FindElement(By.XPath(PageWebElements.toDoCount));

                if (counterValue.Text.Equals("6"))
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks after clicking on toggle the counter decrements by 1
        /// </summary>
        /// <param name="data">data list</param>
        /// <returns>true if successful else returns false</returns>
        public static bool CheckTheToDoCounterDecrementOnItemChecked(List<string> data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();

                EnterDataInToDoList(data);
                IWebElement yogaToggle = driver.FindElement(By.XPath(PageWebElements.yogaClassToggle));
                yogaToggle.Click();

                IWebElement counterValue = driver.FindElement(By.XPath(PageWebElements.toDoCount));

                if (counterValue.Text.Equals("2"))
                {
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks the footer text which contains 'Double-click to edit a todo'
        /// </summary>
        /// <returns>true if successful else returns false</returns>
        public static string CheckDoubleClickInfoPresentOnFooter()
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement doubleClickText = driver.FindElement(By.XPath(PageWebElements.doubleClickText));
                return doubleClickText.Text.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Enters data to the todo list by simply entering values and pressing enter key
        /// </summary>
        /// <param name="data">data in string format</param>
        /// <returns>true if successful else returns false</returns>
        public static bool EnterSpecialCharacters(string data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
                wntbdTextControl.Click();
                wntbdTextControl.SendKeys(data);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wntbdTextControl.SendKeys(Keys.Return);

                IWebElement specialCharacters = driver.FindElement(By.XPath(PageWebElements.specialCharacter));

                if (specialCharacters.Text.ToString() == data)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tries to enter blank data by pressing enter key
        /// </summary>
        /// <returns>true if successful else returns false</returns>
        public static bool EnterBlankData()
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
                wntbdTextControl.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wntbdTextControl.SendKeys(Keys.Return);
                wntbdTextControl.SendKeys(Keys.Return);
                wntbdTextControl.SendKeys(Keys.Return);
                try
                {
                    IWebElement todoCounter = driver.FindElement(By.XPath(PageWebElements.toDoCount));
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Tries to enter spaces and then pressing enter key
        /// </summary>
        /// <param name="data">blank data with spaces</param>
        /// <returns>true if successful else returns false</returns>
        public static bool EnterSpacesAndNoCharacters(string data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
                wntbdTextControl.Click();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wntbdTextControl.SendKeys(data);
                wntbdTextControl.SendKeys(Keys.Space);
                wntbdTextControl.SendKeys(Keys.Space);
                wntbdTextControl.SendKeys(Keys.Space);
                wntbdTextControl.SendKeys(Keys.Enter);
                try
                {
                    IWebElement todoCounter = driver.FindElement(By.XPath(PageWebElements.toDoCount));
                }
                catch (Exception)
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Enters 100 char data to the todo list by entering values and pressing enter key
        /// </summary>
        /// <param name="data">100 char data in string format</param>
        /// <returns>true if successful else returns false</returns>
        public static bool Enter100CharDataToCheckBoundryLimit(string data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
                wntbdTextControl.Click();
                wntbdTextControl.SendKeys(data);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wntbdTextControl.SendKeys(Keys.Return);

                IWebElement charData100 = driver.FindElement(By.XPath(PageWebElements.CharData100));

                if (charData100.Text.ToString() == data)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks if the data persists even after the browser is refreshed
        /// </summary>
        /// <param name="data">Data in string format</param>
        /// <returns>true if successful else returns false</returns>
        public static bool ConfirmDataPersistOnRefresh(string data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
                wntbdTextControl.Click();
                wntbdTextControl.SendKeys(data);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                wntbdTextControl.SendKeys(Keys.Return);

                IWebElement yogaClassText = driver.FindElement(By.XPath(PageWebElements.yogaClassText));

                if (yogaClassText.Text.Contains("Yoga Class"))
                {
                    driver.Navigate().Refresh();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    yogaClassText = driver.FindElement(By.XPath(PageWebElements.yogaClassText));
                    if (yogaClassText.Text.Contains("Yoga Class"))
                    {
                        return true;
                    }
                    return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checks if duplicate names are allowed to be entered in the ToDoMVC list
        /// </summary>
        /// <param name="data">data list</param>
        /// <returns>true if successful else returns false</returns>
        public static bool CheckDuplicateEntryAllowed(List<string> data)
        {
            try
            {
                driver = SeleniumHelper.getDriver();
                IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
                wntbdTextControl.Click();
                foreach (var item in data)
                {
                    wntbdTextControl.SendKeys(item);
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                    wntbdTextControl.SendKeys(Keys.Return);
                }
                IWebElement li1 = driver.FindElement(By.XPath(PageWebElements.li1));
                IWebElement li2 = driver.FindElement(By.XPath(PageWebElements.li2));
                IWebElement li3 = driver.FindElement(By.XPath(PageWebElements.li3));

                if (li1.Text.ToString() == li2.Text.ToString())
                {
                    if (li2.Text.ToString() == li3.Text.ToString())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        /// <summary>
        /// Checks if double clicking on the list item makes it editable and available for changing its values
        /// </summary>
        /// <param name="data">data in string formatr</param>
        /// <returns>true if successful else return false</returns>
        public static bool CheckListItemEditableOnDoubleClick(string data)
        {
            driver = SeleniumHelper.getDriver();
            IWebElement wntbdTextControl = driver.FindElement(By.XPath(PageWebElements.whatNeedsToBeDoneTextControl));
            wntbdTextControl.Click();
            wntbdTextControl.SendKeys(data);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            wntbdTextControl.SendKeys(Keys.Return);

            Actions action = new Actions(driver);
            IWebElement yogaClassLabel = driver.FindElement(By.XPath(PageWebElements.li));
            action.MoveToElement(yogaClassLabel).Perform();
            action.DoubleClick(yogaClassLabel).Perform();
            IWebElement editableBox = driver.FindElement(By.XPath(PageWebElements.editableBox));

            editableBox.Click();
            editableBox.SendKeys("Changed");
            wntbdTextControl.SendKeys(Keys.Enter);
            yogaClassLabel = driver.FindElement(By.XPath(PageWebElements.li));
            if (yogaClassLabel.Text.ToString().Equals("Yoga ClassChanged"))
                return true;
            return false;
        }

        /// <summary>
        /// Enumeration for footer links which will be used in switch condition
        /// </summary>
        public enum FooterLinks
        {
            SamSaccone,
            ColinEberhardt,
            Angular2,
            TodoMVC
        }
    }
}
