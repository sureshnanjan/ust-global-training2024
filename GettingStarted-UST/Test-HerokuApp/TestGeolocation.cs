import org.junit.jupiter.api.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.chrome.ChromeDriver;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class GeolocationTest
{/ 
    
        /// <summary>
        /// Test to Validate Title is Correct
        /// </summary>
        [Test]
        public void GeolocationScreenTitleIsCorrect()
        {
            //Arrange
            IHomeScreen page = null;
            string expectedTitle = "Geolocation";
            //Action
            string actualTitle = page.getTitle();
            //Assert
            Assert.That(actualTitle, Is.EqualTo(expectedTitle));

        }



        @Test
    public void testGeolocation()
    {
        // Set the path to your ChromeDriver executable
        System.setProperty("webdriver.chrome.driver", "path/to/chromedriver");

        // Initialize WebDriver
        WebDriver driver = new ChromeDriver();

        // Open the website
        driver.get("https://example.com");

        // Click on the "Where am I" button
        WebElement whereAmIButton = driver.findElement(By.id("where-am-i-button"));
        whereAmIButton.click();

        // Handle the permission popup
        WebElement allowButton = driver.findElement(By.id("allow-button"));
        allowButton.click();

        // Wait for the location to be retrieved
        WebElement latitudeElement = driver.findElement(By.id("Latitude:"));
        WebElement longitudeElement = driver.findElement(By.id("Longitude:"));

        // Get latitude and longitude values
        String latitude = latitudeElement.getText();
        String longitude = longitudeElement.getText();

        // Validate latitude and longitude values
        assertEquals("Expected Latitude", latitude);
        assertEquals("Expected Longitude", longitude);

        // Close the browser
        driver.quit();
    }
}
