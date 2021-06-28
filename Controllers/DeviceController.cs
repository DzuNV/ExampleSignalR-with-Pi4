using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Device.Gpio;


namespace DeviceGPIO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
        {
      
      // [HttpGet]
      // [Route("TurnOn")]
      // public void TurnOn(int pin = 24)
      // {
      //   using var controller = new GpioController();
      //   controller.OpenPin(pin, PinMode.Output);
      //   controller.Write(pin, PinValue.High);
      //   Thread.Sleep(5000);
      // }

      // [HttpGet]
      // [Route("TurnOff")]
      // public void TurnOff(int pin = 24)
      // {
      //   using var controller = new GpioController();
      //   controller.OpenPin(pin, PinMode.Output);
      //   controller.Write(pin, PinValue.Low);
      // }
        

     
          // private Service ServiceInstance { get; }
          [HttpGet]
          [Route("TurnOn")]
          public void TurnOn([FromServices] GpioService gpioService)
          {
              gpioService.TurnOn();
              
          }

          [HttpGet]
          [Route("TurnOff")]
          public void TurnOff([FromServices] GpioService gpioService)
          {
            gpioService.TurnOff();
          }
          [HttpGet]
          [Route("OpenPin")]
          public void OpenPin ([FromServices] GpioService gpioService)
          {
            gpioService.OpenPin();
          }




    }
}