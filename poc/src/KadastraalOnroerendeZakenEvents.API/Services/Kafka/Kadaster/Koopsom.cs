// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen, version 1.7.7.5
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Kadaster
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using global::Avro;
	using global::Avro.Specific;
	
	public partial class Koopsom : ISpecificRecord
	{
		public static Schema _SCHEMA = Schema.Parse("{\"type\":\"record\",\"name\":\"Koopsom\",\"namespace\":\"Kadaster\",\"fields\":[{\"name\":\"Bedra" +
				"g\",\"type\":\"long\"},{\"name\":\"Koopjaar\",\"type\":\"int\"},{\"name\":\"IndicatieMetMeerObje" +
				"ctenVerkregen\",\"type\":\"boolean\"}]}");
		private long _Bedrag;
		private int _Koopjaar;
		private bool _IndicatieMetMeerObjectenVerkregen;
		public virtual Schema Schema
		{
			get
			{
				return Koopsom._SCHEMA;
			}
		}
		public long Bedrag
		{
			get
			{
				return this._Bedrag;
			}
			set
			{
				this._Bedrag = value;
			}
		}
		public int Koopjaar
		{
			get
			{
				return this._Koopjaar;
			}
			set
			{
				this._Koopjaar = value;
			}
		}
		public bool IndicatieMetMeerObjectenVerkregen
		{
			get
			{
				return this._IndicatieMetMeerObjectenVerkregen;
			}
			set
			{
				this._IndicatieMetMeerObjectenVerkregen = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.Bedrag;
			case 1: return this.Koopjaar;
			case 2: return this.IndicatieMetMeerObjectenVerkregen;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.Bedrag = (System.Int64)fieldValue; break;
			case 1: this.Koopjaar = (System.Int32)fieldValue; break;
			case 2: this.IndicatieMetMeerObjectenVerkregen = (System.Boolean)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
