﻿using ELIXIR.DATA.CORE.ICONFIGURATION;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ELIXIR.API.Controllers.REPORT_CONTROLLER
{

    public class ReportController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportController(IUnitOfWork unitofwork)
        {
            _unitOfWork = unitofwork;
        }

        [HttpGet]
        [Route("QcReceivingReport")]
        public async Task<IActionResult> QcReceivingReport([FromQuery] string DateFrom, [FromQuery] string DateTo)
        {

            var orders = await _unitOfWork.Report.QcRecevingReport(DateFrom, DateTo);

            return Ok(orders);

        }

        [HttpGet]
        [Route("WarehouseReceivingReport")]
        public async Task<IActionResult> WarehouseReceivingReport([FromQuery] string DateFrom, [FromQuery] string DateTo)
        {

            var orders = await _unitOfWork.Report.WarehouseRecivingReport(DateFrom, DateTo);

            return Ok(orders);

        }

        [HttpGet]
        [Route("TransformationHistoryReport")]
        public async Task<IActionResult> TransformationHistoryReport([FromQuery] string DateFrom, [FromQuery] string DateTo)
        {

            var orders = await _unitOfWork.Report.TransformationReport(DateFrom, DateTo);

            return Ok(orders);

        }

        [HttpGet]
        [Route("MoveOrderHistory")]
        public async Task<IActionResult> MoveOrderHistory([FromQuery] string DateFrom, [FromQuery] string DateTo)
        {

            var orders = await _unitOfWork.Report.MoveOrderReport(DateFrom, DateTo);

            return Ok(orders);

        }

        [HttpGet]
        [Route("MiscellaneousReceiptReport")]
        public async Task<IActionResult> MiscellaneousReceiptReport([FromQuery] string DateFrom, [FromQuery] string DateTo)
        {

            var receipt = await _unitOfWork.Report.MReceiptReport(DateFrom, DateTo);

            return Ok(receipt);

        }

        [HttpGet]
        [Route("MiscellaneousIssueReport")]
        public async Task<IActionResult> MiscellaneousIssueReport([FromQuery] string DateFrom, [FromQuery] string DateTo)
        {

            var issue = await _unitOfWork.Report.MIssueReport(DateFrom, DateTo);

            return Ok(issue);

        }

    }
}
