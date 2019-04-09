using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Drawing.Imaging;

namespace RandREng.Utility.Documents
{
	//public class MTiffDocument : IDocument
	//{
	//	TiffBitmapEncoder encoder;
	//	Stream imageStreamSource;
	//	TiffBitmapDecoder decoder;

	//	/// <summary>
	//	/// 
	//	/// </summary>
	//	public string FileName { get; set; }

	//	public MTiffDocument()
	//	{
	//	}

	//	~MTiffDocument()
	//	{
	//		if (this.imageStreamSource != null)
	//		{
	//			this.imageStreamSource.Dispose();
	//			this.imageStreamSource = null;
	//		}
	//	}

	//	public void Open(string fileName)
	//	{
	//		this.imageStreamSource = new MemoryStream();
	//		Bitmap b = new Bitmap(fileName);
	//		b.Save(imageStreamSource, ImageFormat.Tiff);
	//		b.Dispose();
	//		this.imageStreamSource.Seek(0, SeekOrigin.Begin);
	//		this.decoder = new TiffBitmapDecoder(imageStreamSource, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.OnDemand);
	//	}

	//	public int Count { get { return decoder.Frames.Count; } }

	//	public Bitmap GetImage(int index)
	//	{
	//		Bitmap bm = null;
	//		using (MemoryStream mem = new MemoryStream())
	//		{
	//			TiffBitmapEncoder _encoder = new TiffBitmapEncoder();
	//			BitmapSource bs = decoder.Frames[index];
	//			_encoder.Compression = TiffCompressOption.Ccitt4;
	//			_encoder.Frames.Add(decoder.Frames[index]);
	//			_encoder.Save(mem);
	//			mem.Flush();
	//			mem.Seek(0, SeekOrigin.Begin);
	//			bm = new Bitmap(mem);
	//		}
	//		return bm;
	//	}


	//	static public void Split(string fileName)
	//	{
	//		using (Stream imageStreamSource = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read))
	//		{
	//			TiffBitmapDecoder decoder = new TiffBitmapDecoder(imageStreamSource, BitmapCreateOptions.DelayCreation, BitmapCacheOption.OnDemand);

	//			int count = decoder.Frames.Count;
	//			for (int _i = 0; _i < count; _i++)
	//			{
	//				string outName = Path.GetDirectoryName(fileName) + @"\" + Path.GetFileNameWithoutExtension(fileName) + "_PAGE" + _i + Path.GetExtension(fileName);

	//				using (FileStream splitFiles = new FileStream(outName, FileMode.Create))
	//				{
	//					TiffBitmapEncoder encoder = new TiffBitmapEncoder();
	//					encoder.Compression = TiffCompressOption.Ccitt4;
	//					List<ColorContext> c = new List<ColorContext>();
	//					c.Add(new ColorContext(System.Windows.Media.PixelFormats.BlackWhite));
	//					encoder.ColorContexts = new System.Collections.ObjectModel.ReadOnlyCollection<ColorContext>(c);
	//					encoder.Frames.Add(decoder.Frames[_i]);
	//					encoder.Save(splitFiles);
	//				}
	//			}
	//		}
	//		return;
	//	}

	//	public void Add(Bitmap bm)
	//	{
	//		this.Add(bm, RotateFlipType.RotateNoneFlipNone);
	//	}


	//	/// <summary>
	//	/// 
	//	/// </summary>
	//	/// <param name="image"></param>
	//	public void Add(Bitmap bm, RotateFlipType rotate)
	//	{
	//		Bitmap image = bm;

	//		if (rotate != RotateFlipType.RotateNoneFlipNone)
	//		{
	//			bm.RotateFlip(rotate);
	//		}

	//		if (this.encoder == null)
	//		{
	//			this.encoder = new TiffBitmapEncoder();
	//			this.encoder.Compression = TiffCompressOption.Ccitt4;
	//		}
	//		using (MemoryStream mem = new MemoryStream())
	//		{
	//			// Lock the bitmap's bits.  
	//			Rectangle rect = new Rectangle(0, 0, bm.Width, bm.Height);
	//			System.Drawing.Imaging.BitmapData bmpData = bm.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format1bppIndexed);

	//			// Get the address of the first line.
	//			IntPtr ptr = bmpData.Scan0;

	//			// Declare an array to hold the bytes of the bitmap.
	//			int bytes = Math.Abs(bmpData.Stride) * image.Height;
	//			byte[] rgbValues = new byte[bytes];

	//			// Copy the RGB values into the array.
	//			List<System.Windows.Media.Color> colors = new List<System.Windows.Media.Color>();
	//			colors.Add(System.Windows.Media.Colors.Black);
	//			colors.Add(System.Windows.Media.Colors.White);
	//			BitmapPalette myPalette = new BitmapPalette(colors);
	//			BitmapSource bs = BitmapSource.Create(image.Width, image.Height, image.HorizontalResolution, image.VerticalResolution, System.Windows.Media.PixelFormats.Indexed1, myPalette, ptr, bytes, bmpData.Stride);
	//			this.encoder.Frames.Add(BitmapFrame.Create(bs));
	//			// Unlock the bits.
	//			image.UnlockBits(bmpData);


	//		}
	//	}

	//	public void Save(Bitmap bm, string filename)
	//	{
	//		Save(bm, filename, RotateFlipType.RotateNoneFlipNone);
	//	}

	//	public void Save(Bitmap bm, string filename, RotateFlipType rotate)
	//	{
	//		Bitmap image = bm;

	//		using (FileStream stream = new FileStream(filename, FileMode.Create))
	//		{
	//			if (rotate != RotateFlipType.RotateNoneFlipNone)
	//			{
	//				image.RotateFlip(rotate);
	//			}

	//			TiffBitmapEncoder _encoder = new TiffBitmapEncoder();
	//			_encoder.Compression = TiffCompressOption.Ccitt4;


	//			// Lock the bitmap's bits.  
	//			Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);
	//			System.Drawing.Imaging.BitmapData bmpData = image.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, image.PixelFormat);

	//			// Get the address of the first line.
	//			IntPtr ptr = bmpData.Scan0;

	//			// Declare an array to hold the bytes of the bitmap.
	//			int bytes = Math.Abs(bmpData.Stride) * image.Height;
	//			byte[] rgbValues = new byte[bytes];

	//			// Copy the RGB values into the array.
	//			List<System.Windows.Media.Color> colors = new List<System.Windows.Media.Color>();
	//			colors.Add(System.Windows.Media.Colors.Black);
	//			colors.Add(System.Windows.Media.Colors.White);
	//			BitmapPalette myPalette = new BitmapPalette(colors);
	//			BitmapSource bs = BitmapSource.Create(image.Width, image.Height, image.HorizontalResolution, image.VerticalResolution, System.Windows.Media.PixelFormats.BlackWhite, myPalette, ptr, bytes, bmpData.Stride);
	//			_encoder.Frames.Add(BitmapFrame.Create(bs));
	//			// Unlock the bits.
	//			image.UnlockBits(bmpData);
	//			_encoder.Save(stream);
	//			_encoder = null;
	//		}
	//	}

	//	/// <summary>
	//	/// 
	//	/// </summary>
	//	public void Close()
	//	{
	//		if (this.encoder != null)
	//		{
	//			FileStream stream = new FileStream(this.FileName, FileMode.Create);
	//			this.encoder.Save(stream);
	//			this.encoder = null;
	//			stream.Dispose();
	//		}

	//		if (this.imageStreamSource != null)
	//		{
	//			this.imageStreamSource.Close();
	//			this.imageStreamSource.Dispose();
	//			this.imageStreamSource = null;
	//		}

	//	}
	//}

	//internal class ImageRenderListener : IRenderListener
	//{
	//	#region Fields

	//	public Bitmap Image = null;
	//	Dictionary<System.Drawing.Image, string> images = new Dictionary<System.Drawing.Image, string>();
	//	#endregion Fields

	//	#region Properties

	//	public Dictionary<System.Drawing.Image, string> Images
	//	{
	//		get { return images; }
	//	}
	//	#endregion Properties

	//	#region Methods

	//	#region Public Methods

	//	public void BeginTextBlock() { }

	//	public void EndTextBlock() { }

	//	public void RenderImage(ImageRenderInfo renderInfo)
	//	{
	//		PdfImageObject image = renderInfo.GetImage();
	//		PdfName filter = (PdfName)image.Get(PdfName.FILTER);

	//		int width = Convert.ToInt32(image.Get(PdfName.WIDTH).ToString());
	//		int bitsPerComponent = Convert.ToInt32(image.Get(PdfName.BITSPERCOMPONENT).ToString());
	//		string subtype = image.Get(PdfName.SUBTYPE).ToString();
	//		int height = Convert.ToInt32(image.Get(PdfName.HEIGHT).ToString());
	//		int length = Convert.ToInt32(image.Get(PdfName.LENGTH).ToString());
	//		string colorSpace = image.Get(PdfName.COLORSPACE).ToString();

	//		/* It appears to be safe to assume that when filter == null, PdfImageObject 
	//		 * does not know how to decode the image to a System.Drawing.Image. 
	//		 * 
	//		 * Uncomment the code above to verify, but when I’ve seen this happen, 
	//		 * width, height and bits per component all equal zero as well. */
	//		if (filter != null)
	//		{
	//			System.Drawing.Bitmap drawingImage = image.GetDrawingImage() as Bitmap;

	//			string extension = ".";

	//			if (filter == PdfName.DCTDECODE)
	//			{
	//				extension += PdfImageObject.ImageBytesType.JPG.FileExtension;
	//			}
	//			else if (filter == PdfName.JPXDECODE)
	//			{
	//				extension += PdfImageObject.ImageBytesType.JP2.FileExtension;
	//			}
	//			else if (filter == PdfName.FLATEDECODE)
	//			{
	//				extension += PdfImageObject.ImageBytesType.PNG.FileExtension;
	//			}
	//			else if (filter == PdfName.LZWDECODE)
	//			{
	//				extension += PdfImageObject.ImageBytesType.CCITT.FileExtension;
	//			}

	//			/* Rather than struggle with the image stream and try to figure out how to handle 
	//			 * BitMapData scan lines in various formats (like virtually every sample I’ve found 
	//			 * online), use the PdfImageObject.GetDrawingImage() method, which does the work for us. */
	//			this.Images.Add(drawingImage, extension);
	//			this.Image = drawingImage;
	//		}
	//	}
	//	public void RenderText(TextRenderInfo renderInfo) { }

	//	//public void test()
	//	//{

	//	//	PdfSharp.Pdf.Filters.FlateDecode flate = new PdfSharp.Pdf.Filters.FlateDecode();
	//	//	byte[] decodedBytes = flate.Decode(image.Stream.Value);

	//	//	System.Drawing.Imaging.PixelFormat pixelFormat;

	//	//	switch (bitsPerComponent)
	//	//	{
	//	//		case 1:
	//	//			pixelFormat = PixelFormat.Format1bppIndexed;
	//	//			break;
	//	//		case 8:
	//	//			pixelFormat = PixelFormat.Format8bppIndexed;
	//	//			break;
	//	//		case 24:
	//	//			pixelFormat = PixelFormat.Format24bppRgb;
	//	//			break;
	//	//		default:
	//	//			throw new Exception("Unknown pixel format " + bitsPerComponent);
	//	//	}

	//	//	Bitmap bmp = new Bitmap(width, height, pixelFormat);
	//	//	var bmpData = bmp.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, pixelFormat);
	//	//	int length = (int)Math.Ceiling(width * bitsPerComponent / 8.0);
	//	//	for (int i = 0; i < height; i++)
	//	//	{
	//	//		int offset = i * length;
	//	//		int scanOffset = i * bmpData.Stride;
	//	//		Marshal.Copy(decodedBytes, offset, new IntPtr(bmpData.Scan0.ToInt32() + scanOffset), length);
	//	//	}
	//	//	bmp.UnlockBits(bmpData);
	//	//	using (FileStream fs = new FileStream(@"D:\BeyondBGCM\BeyondBGCM\PDFToWord\" + String.Format("Image{0}.png", count++), FileMode.Create, FileAccess.Write))
	//	//	{
	//	//		bmp.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
	//	//	}
	//	//}

	//	#endregion Public Methods

	//	#endregion Methods
	//}

	//public class MyImageRenderListener : IRenderListener
	//{
	//	public void RenderText(TextRenderInfo renderInfo) { }
	//	public void BeginTextBlock() { }
	//	public void EndTextBlock() { }

	//	public Bitmap Image = null;
	//	public void RenderImage(ImageRenderInfo renderInfo)
	//	{
	//		try
	//		{
	//			PdfImageObject image = renderInfo.GetImage();
	//			if (image == null) return;

	//			using (MemoryStream ms = new MemoryStream(image.GetImageAsBytes()))
	//			{
	//				Bitmap i = (System.Drawing.Bitmap)Bitmap.FromStream(ms);
	//				Image = (System.Drawing.Bitmap)i.Clone();
	//				i.Dispose();
	//				//                    int dpi = i.Height / 11;
	//				int yDPI = Image.Height / 11;
	//				int xDPI = (Image.Width * 2) / 17;

	//				xDPI = Math.Abs(xDPI - 300) < 10 ? 300 : xDPI;
	//				yDPI = Math.Abs(yDPI - 300) < 10 ? 300 : yDPI;
	//				xDPI = Math.Abs(xDPI - 600) < 10 ? 600 : xDPI;
	//				yDPI = Math.Abs(yDPI - 600) < 10 ? 600 : yDPI;

	//				if (xDPI == yDPI)
	//				{
	//					Image.SetResolution(xDPI, yDPI);
	//				}
	//				else
	//				{

	//				}
	//			}
	//		}
	//		catch (IOException)
	//		{
	//			/*
 //                * pass-through; image type not supported by iText[Sharp]; e.g. jbig2
 //               */
	//		}
	//	}
	//}
}
