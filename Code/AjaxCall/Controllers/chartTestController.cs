using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxCall.Models;
using System.Collections;
using System.Web.Helpers;
using Logic.Abstract;
using Logic.Concreate;

namespace AjaxCall.Controllers
{
	public class chartTestController : Controller
	{
		// Follow this link for creating charts
		//http://www.technologycrowds.com/2016/07/how-to-create-charts-using-MVC.html

		private IEMP iemp;
		public chartTestController()
		{
			iemp = new EFEMp();
		}
		//
		// GET: /chartTest/

		public ActionResult Index()
		{
			return View();
		}
		public ActionResult _chart()
		{
			return View();
			//return PartialView("_chart");
		}

		public ActionResult CharterColumn()
		{
			//var _data = iemp.Chart;
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
			.AddTitle("Chart for Growth [Column Chart]")
		   .AddSeries("Default", chartType: "column", xValue: xValue, yValues: yValue)
				  .Write("bmp");

			return null;
		}

		public ActionResult ChartBar()
		{

			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
			.AddTitle("Chart for Growth [Bar Chart]")
					.AddSeries("Default", chartType: "Bar", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}

		public ActionResult ChartPie()
		{

			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
			.AddTitle("Chart for Growth [Pie Chart]")
					.AddLegend("Summary")
					.AddSeries("Default", chartType: "Pie", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}

		public ActionResult ChartThreelinebreak()
		{

			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			/// SeriesChartType.Candlestick
			new Chart(width: 600, height: 400, theme: ChartTheme.Vanilla3D)
			.AddTitle("Chart for Growth [Three Line Break Chart]")
					.AddSeries("Default", chartType: "Candlestick", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}

		public ActionResult Bubblebreak()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.Bubble
			.AddTitle("Chart for Growth [Bubble Chart]")
					.AddLegend("Summary")
					.AddSeries("Default", chartType: "Bubble", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}

		public ActionResult DoughnutGraph()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.Doughnut
			.AddTitle("Chart for Growth [Doughnut Chart]")
					.AddLegend("Summary")
					.AddSeries("Default", chartType: "Doughnut", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}

		public ActionResult ChartStackedBar100()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.StackedBar100
			.AddTitle("Chart for Growth [StackedBar100 Chart]")
					.AddSeries("Default", chartType: "StackedBar100", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}

		public ActionResult ChartBoxPlot()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.BoxPlot
			.AddTitle("Chart for Growth [BoxPlot Chart]")
					.AddSeries("Default", chartType: "BoxPlot", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}

		public ActionResult ChartPyramid()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.Pyramid
			.AddTitle("Chart for Growth [Pyramid Chart]")
					.AddLegend("Summary")
					.AddSeries("Default", chartType: "Pyramid", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}


		public ActionResult ChartPolar()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.Polar
			.AddTitle("Chart for Growth [Polar Chart]")
					.AddSeries("Default", chartType: "Polar", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}

		public ActionResult RadarChart()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.Radar
			.AddTitle("Chart for Growth [Radar Chart]")
					.AddSeries("Default", chartType: "Radar", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}


		public ActionResult ChartRangeBar()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.RangeBar
			.AddTitle("Chart for Growth [RangeBar Chart]")
					.AddSeries("Default", chartType: "RangeBar", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}


		public ActionResult ChartFunnel()
		{
			ArrayList xValue = new ArrayList();
			ArrayList yValue = new ArrayList();

			var results = iemp.Chart;

			results.ToList().ForEach(rs => xValue.Add(rs.Growth_Year));
			results.ToList().ForEach(rs => yValue.Add(rs.Growth_Value));

			new Chart(width: 600, height: 400, theme: ChartTheme.Green)

			/// SeriesChartType.Funnel
			.AddTitle("Chart for Growth [Funnel Chart]")
			.AddLegend("Summary")
					.AddSeries("Default", chartType: "Funnel", xValue: xValue, yValues: yValue)
					.Write("bmp");

			return null;
		}
	}
}
