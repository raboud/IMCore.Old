using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace IMCore.TypesAndInterfaces
{
	public interface IDocumentManipulator
	{
		List<Bitmap> Bitmaps { get; }
		//		ImageList Thumbnails { get; }
		void Open(string fileName);
		void SaveDestination(string fileName);
		List<int> Source { get; set; }
		List<int> Destination { get; set; }
	}

	public interface ICompany
	{
		Type CustomerJobsFormType { get; }
		Type AddEditJobFormType { get; }
		Type AddEditOrderFormType { get; }
	}

	//public class InstanceConfig : ConfigurationElement
	//{
	//	public InstanceConfig() { }

	//	public InstanceConfig(string name, string server, string catalog)
	//	{
	//		Name = name;
	//		SQLServer = server;
	//		InitialCatalog = catalog;
	//	}

	//	[ConfigurationProperty("Name", DefaultValue = "", IsRequired = true, IsKey = true)]
	//	public String Name
	//	{
	//		get { return (string)this["Name"]; }
	//		set { this["Name"] = value; }
	//	}

	//	[ConfigurationProperty("SQLServer", DefaultValue = "", IsRequired = true, IsKey = false)]
	//	public string SQLServer
	//	{
	//		get { return (string)this["SQLServer"]; }
	//		set { this["SQLServer"] = value; }
	//	}

	//	[ConfigurationProperty("InitialCatalog", DefaultValue = "", IsRequired = true, IsKey = false)]
	//	public string InitialCatalog
	//	{
	//		get { return (string)this["InitialCatalog"]; }
	//		set { this["InitialCatalog"] = value; }
	//	}
	//}
	//public class InstanceCollection : ConfigurationElementCollection
	//{
	//	public InstanceCollection()
	//	{
	//	}

	//	new public InstanceConfig this[string name]
	//	{
	//		get { return (InstanceConfig)BaseGet(name); }
	//	}

	//	public InstanceConfig this[int index]
	//	{
	//		get { return (InstanceConfig)BaseGet(index); }
	//		set
	//		{
	//			if (BaseGet(index) != null)
	//			{
	//				BaseRemoveAt(index);
	//			}
	//			BaseAdd(index, value);
	//		}
	//	}

	//	public void Add(InstanceConfig serviceConfig)
	//	{
	//		BaseAdd(serviceConfig);
	//	}

	//	public void Clear()
	//	{
	//		BaseClear();
	//	}

	//	public void Remove(InstanceConfig serviceConfig)
	//	{
	//		BaseRemove(serviceConfig.Name);
	//	}

	//	protected override ConfigurationElement CreateNewElement()
	//	{
	//		return new InstanceConfig();
	//	}

	//	protected override object GetElementKey(ConfigurationElement element)
	//	{
	//		return ((InstanceConfig)element).Name;
	//	}

	//	public void RemoveAt(int index)
	//	{
	//		BaseRemoveAt(index);
	//	}

	//	public void Remove(string name)
	//	{
	//		BaseRemove(name);
	//	}
	//}
	//public class InstanceConfigurationSection : ConfigurationSection
	//{
	//	[ConfigurationProperty("Instances", IsDefaultCollection = false)]
	//	[ConfigurationCollection(typeof(InstanceCollection),
	//		AddItemName = "add",
	//		ClearItemsName = "clear",
	//		RemoveItemName = "remove")]
	//	public InstanceCollection Instances
	//	{
	//		get
	//		{
	//			return (InstanceCollection)base["Instances"];
	//		}
	//	}
	//}

}
