﻿
using System.Xml;
namespace SmartGunBulletManager.Utils
{
    /// <summary>
    /// XML操作类
    /// </summary>
    public class XmlHelper
    {
        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="node">节点</param>
        /// <param name="attribute">属性名，非空时返回该属性值，否则返回串联值</param>
        /// <returns>string</returns>
        /**************************************************
         * 使用示列:
         * XmlHelper.Read(path, "/Node", "")
         * XmlHelper.Read(path, "/Node/Element[@Attribute='Name']", "Attribute")
         ************************************************/
        public static string Read(string path, string node, string attribute)
        {
            string value = "";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode xn = doc.SelectSingleNode(node);
            value = (attribute == null ? xn.InnerText : xn.Attributes[attribute].Value);
            return value;
        }

        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="node">节点</param>
        /// <param name="element">元素名，非空时插入新元素，否则在该元素中插入属性</param>
        /// <param name="attribute">属性名，非空时插入该元素属性值，否则插入元素值</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        /**************************************************
         * 使用示列:
         * XmlHelper.Insert(path, "/Node", "Element", "", "Value")
         * XmlHelper.Insert(path, "/Node", "Element", "Attribute", "Value")
         * XmlHelper.Insert(path, "/Node", "", "Attribute", "Value")
         ************************************************/
        public static void Insert(string path, string node, string element, string attribute, string value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode xn = doc.SelectSingleNode(node);
            if (element.Equals(""))
            {
                if (!attribute.Equals(""))
                {
                    XmlElement xe = (XmlElement)xn;
                    xe.SetAttribute(attribute, value);
                }
            }
            else
            {
                XmlElement xe = doc.CreateElement(element);
                if (attribute.Equals(""))
                {
                    xe.InnerText = value;
                }
                else
                {
                    xe.SetAttribute(attribute, value);
                }
                xn.AppendChild(xe);
            }
            doc.Save(path);
        }

        /// <summary>
        /// 修改数据
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="node">节点</param>
        /// <param name="attribute">属性名，非空时修改该节点属性值，否则修改节点值</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        /**************************************************
         * 使用示列:
         * XmlHelper.Insert(path, "/Node", "", "Value")
         * XmlHelper.Insert(path, "/Node", "Attribute", "Value")
         ************************************************/
        public static void Update(string path, string node, string attribute, string value)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode xn = doc.SelectSingleNode(node);
            XmlElement xe = (XmlElement)xn;
            if (attribute.Equals(""))
            {
                xe.InnerText = value;
            }
            else
            {
                xe.SetAttribute(attribute, value);
            }
            doc.Save(path);
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="path">路径</param>
        /// <param name="node">节点</param>
        /// <param name="attribute">属性名，非空时删除该节点属性值，否则删除节点值</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        /**************************************************
         * 使用示列:
         * XmlHelper.Delete(path, "/Node", "")
         * XmlHelper.Delete(path, "/Node", "Attribute")
         ************************************************/
        public static void Delete(string path, string node, string attribute)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlNode xn = doc.SelectSingleNode(node);
            XmlElement xe = (XmlElement)xn;
            if (attribute.Equals(""))
            {
                xn.ParentNode.RemoveChild(xn);
            }
            else
            {
                xe.RemoveAttribute(attribute);
            }
            doc.Save(path);
        }
    }
}