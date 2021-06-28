using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Device.Gpio;

namespace DeviceGPIO
{
    
    public class GpioService
    {
      private readonly GpioController gpioController;
      public GpioService()
      {
        gpioController = new GpioController();
      }

      public void OpenPin()
      {
          gpioController.OpenPin(24, PinMode.Output);
        
      }
      
      public void TurnOn()
      {
          gpioController.Write(24, PinValue.High);
      }
      
      public void TurnOff()
      {
          gpioController.Write(24, PinValue.Low);
      }




     }
 }