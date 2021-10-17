﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApi.Bussiness.DTO;
using WebApi.Bussiness.IServices;
using WebApi.Data.Entites;
using WebApi.Data.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // POST api/<OrderController>
        //[Authorize (Roles = "USER")]
        [HttpPost]
        public async Task<IActionResult> Checkout(List<CartItemViewModel> listCart, int percentDiscount, Guid userId)
        {
            decimal totalPrice = 0;
            decimal priceDiscount = 0;
            decimal finalPrice = 0;

            var booking = new Booking();

            if (listCart != null) { 
                foreach(CartItemViewModel item in listCart)
                {
                    totalPrice = totalPrice + item.Price;
                }
                if(percentDiscount != 0)
                {
                    priceDiscount = (totalPrice * percentDiscount) / 100;
                    finalPrice = totalPrice - priceDiscount;

                    booking.CreatedAt = DateTime.Now;
                    booking.OriginPrice = totalPrice;
                    booking.TotalPrice = finalPrice;
                    booking.Status = true;
                    booking.UserForeignKey = userId;

                }
                else {
                    booking.CreatedAt = DateTime.Now;
                    booking.OriginPrice = totalPrice;
                    booking.TotalPrice = totalPrice;
                    booking.Status = true;
                    booking.UserForeignKey = userId;
                }
            }
            await _unitOfWork.Booking.Add(booking);
            int status = _unitOfWork.Complete();
            if (status > 0)
            {
                return Ok();
            }
            return BadRequest();
        }

    }
}