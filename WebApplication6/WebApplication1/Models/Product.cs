using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		private int _price;

		public int Price
		{
			get { return _price; }
			set { _price = value; }
		}

		private DateTime _creationDate;

		public DateTime CreationDate
		{
			get { return _creationDate; }
			set { _creationDate = value; }
		}

	}
}