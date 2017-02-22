﻿using System;
using SkiaSharp;
using KimonoCore;
using KimonoCore.Mac;

namespace Kimono
{
	/// <summary>
	/// Author: Unknown
	/// Copyright (c) 2017. All rights reserved.
	/// </summary>
	/// <remarks>Generated by Kimono Designer Wednesday, February 22, 2017.</remarks>
	public class Sketch : KimonoSketch
	{
		#region Computed Properties
		// Global color Orange
		public static KimonoColor Orange { get; set; } = new KimonoColor(255, 128, 0, 255)
		{
			BaseColor = null,
			Name = "Orange",
			AdjustsHue = false,
			AdjustsSaturation = false,
			AdjustsBrightness = false,
			AdjustsAlpha = false,
			HueAdjustment = 30.11767f,
			SaturationAdjustment = 100f,
			BrightnessAdjustment = 100f,
			AlphaAdjustment = 255
		};

		// Global color Purple
		public static KimonoColor Purple { get; set; } = new KimonoColor(128, 0, 255, 255)
		{
			BaseColor = null,
			Name = "Purple",
			AdjustsHue = false,
			AdjustsSaturation = false,
			AdjustsBrightness = false,
			AdjustsAlpha = false,
			HueAdjustment = 270.1177f,
			SaturationAdjustment = 100f,
			BrightnessAdjustment = 100f,
			AlphaAdjustment = 255
		};

		// Global style Oval Style
		public static KimonoStyle OvalStyle { get; set; }

		// Global property UseOrange
		public static KimonoPropertyBoolean UseOrange { get; set; } = new KimonoPropertyBoolean()
		{
			Name = "UseOrange",
			GetsValueFromScript = false,
			ObiScript = "",
			Value = true
		};


		// Global property Color Property
		public static KimonoPropertyColor ColorProperty { get; set; } = new KimonoPropertyColor()
		{
			Name = "Color Property",
			GetsValueFromScript = true,
			ObiScript = "if (Portfolio.GetBoolean(\"UseOrange\")) {\n\tReturn.Color(\"Orange\");\n} else {\n\tReturn.Color(\"Purple\");\n}",
			Value = Orange
		};

		#endregion

		#region Constructors
		/// <summary>
		/// Creates a new instance of the Sketch class.
		/// </summary>
		public Sketch()
		{
			Initialize();
		}

		/// <summary>
		/// Initializes this new instance of the Sketch class.
		/// </summary>
		internal void Initialize()
		{
			// Initialize Oval Style
			OvalStyle = new KimonoStyle()
			{
				StyleType = KimonoStyleType.Standard,
				HasFill = true,
				HasFrame = true
			};

			// Configure new Oval Style
			OvalStyle.Fill.BlendMode = SKBlendMode.SrcOver;
			OvalStyle.Fill.IsAntialias = true;
			OvalStyle.FillColor = Orange;
			OvalStyle.Frame.BlendMode = SKBlendMode.SrcOver;
			OvalStyle.Frame.IsAntialias = true;
			OvalStyle.Frame.StrokeWidth = 1f;
			OvalStyle.Frame.StrokeMiter = 4f;
			OvalStyle.Frame.StrokeJoin = SKStrokeJoin.Mitter;
			OvalStyle.Frame.StrokeCap = SKStrokeCap.Butt;
			OvalStyle.Frame.Color = new SKColor(0, 0, 0, 255);


			// Property connections for Oval Style.
			OvalStyle.PropertyConnections.Add(new KimonoPropertyConnection(KimonoPropertyConnectionPoint.FillColor, ColorProperty));


			// Initialize Sketch
			Name = "Sketch";
			DrawCanvas = true;
			Width = 640f;
			Height = 480f;
			CanvasColor = new SKColor(255, 255, 255, 255);
			Portfolio = new KimonoPortfolio(true);
			Portfolio.Sketches.Add(this);
			ObiScriptPortfolio.Portfolio = Portfolio;


			// Draw Oval shape
			var Oval = new KimonoShapeOval(40.5625f, 47.37891f, 192.1406f, 194.7109f)
			{
				RotationDegrees = 0,
				Visible = true,
				Style = OvalStyle
			};


			Shapes.Add(Oval);
			// Accumulate Kimono objects into the portfolio
			Portfolio.Colors.Add(Orange);
			Portfolio.Colors.Add(Purple);
			Portfolio.Styles.Add(OvalStyle);
			Portfolio.Properties.Add(UseOrange);
			Portfolio.Properties.Add(ColorProperty);


		}
		#endregion

	}
}
