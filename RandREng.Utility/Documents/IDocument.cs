using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace RandREng.Utility.Documents
{
	public interface IDocument
	{
		//        List<Bitmap> Bitmaps { get; }
		//        bool Parse(string fileName);
		//        void BeginParse(string fileName);
		//        void EndParse();

		void Open(string fileName);
		int Count { get; }
		Bitmap GetImage(int index);

		//       void Split(string fileName);
		void Save(Bitmap bm, string filename, RotateFlipType rotate);
		void Save(Bitmap bm, string filename);

		void Add(System.Drawing.Bitmap bm);
		void Add(System.Drawing.Bitmap bm, System.Drawing.RotateFlipType rotate);
		void Close();

		string FileName { get; set; }
	}

	public enum Orientation
	{
		Any,
		Portrait,
		Landscape,
	}
}
