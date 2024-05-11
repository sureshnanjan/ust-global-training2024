using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium.Interactions.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using Utilities;

namespace HerokuWebdriverImplemention
{
    public class ExitIntentPage : HerokuApp, IExitIntent
    {
        private readonly By modalTitle; // //*[@id="ouibounce-modal"]/div[2]/div[1]
        private readonly By modalText; // //*[@id="ouibounce-modal"]/div[2]/div[2]
        private readonly By modalClose; // //*[@id="ouibounce-modal"]/div[2]/div[3]/p
        public ExitIntentPage(IWebDriver currentBrowser): base(currentBrowser)
        {
            this.modalTitle = By.XPath("//*[@id=\"ouibounce-modal\"]/div[2]/div[1]");
            this.modalText = By.XPath("//*[@id=\"ouibounce-modal\"]/div[2]/div[2]");
            this.modalClose = By.XPath("//*[@id=\"ouibounce-modal\"]/div[2]/div[3]/p");
        }
        public void GetDescription()
        {
            throw new NotImplementedException();
        }

        public string GetNotificationDescription()
        {
            throw new NotImplementedException();
        }

        public string GetNotificationTitle()
        {
            throw new NotImplementedException();
        }

        public void GetTitle()
        {
            throw new NotImplementedException();
        }

        public void HandleNotificationMessage(bool sayOK = true)
        {
            throw new NotImplementedException();
        }

        public void MoveMouseOutOfViewPort()
        {

            Point pos = this.driver.Manage().Window.Position;
            var windowSize = this.driver.Manage().Window.Size;
            Console.WriteLine($"The Browser is at position {pos.X} , {pos.Y}");
            Console.WriteLine($"The Browser size is {windowSize.Width} and {windowSize.Height}");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++");
            this.driver.Manage().Window.Size = new Size(windowSize.Width - 100, windowSize.Height - 100);
            windowSize = this.driver.Manage().Window.Size;
            Console.WriteLine($"The Browser is at position {pos.X} , {pos.Y}");
            Console.WriteLine($"The Browser size is {windowSize.Width} and {windowSize.Height}");

            PointerInputDevice mouse = new PointerInputDevice(PointerKind.Mouse);
            mouse.CreatePointerMove(CoordinateOrigin.Viewport, -5, 0, TimeSpan.FromSeconds(1));
            WindowsUtil.SetCursorPos(0, 0);
        }
    }
}
