﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using L1.WcfServiceLibrary.Manager;

namespace L1.WcfServiceLibrary
{
  public class EncyclopediaService : IEncyclopediaService
  {
  
    /// <summary>
    /// Получение списка категорий и информации о энциклопедии
    /// </summary>
    /// <returns></returns>
    public EncyclopediaType GetInfo(string curDir)
    {
      EncyclopediaManager pManager = new EncyclopediaManager();
      EncyclopediaType pEncyclopedia = pManager.Load(curDir);
      return pEncyclopedia;
    }

    /// <summary>
    /// Получить информацию по разделу энциклопедии
    /// </summary>
    /// <param name="sCode"></param>
    /// <returns></returns>
    public EncyclopediaPartType GetPart(string sCode)
    {
            EncyclopediaManager pManager = new EncyclopediaManager();
            EncyclopediaPartType encyclopediaPartType = pManager.Load2(sCode);
            return encyclopediaPartType;
    }

    /// <summary>
    /// Получить полную словарную статью
    /// </summary>
    /// <param name="sCode"></param>
    /// <returns></returns>
    public EncyclopediaArticleType GetArticle(string sPart, string sCode)
    {
            EncyclopediaManager pManager = new EncyclopediaManager();
            EncyclopediaArticleType encyclopediaArticleType = pManager.Load(sPart, sCode);
            return encyclopediaArticleType;
    }

        public void Test(string sDirectory, EncyclopediaType encyclopediaType, EncyclopediaPartType encyclopediaPartType)
        {
            string sDir = Path.Combine(sDirectory, encyclopediaType.Folder);
            Directory.CreateDirectory(sDir);
            
            EncyclopediaManager pManager = new EncyclopediaManager();
            pManager.Save(sDirectory, encyclopediaType);
            pManager.Save(sDir, encyclopediaPartType);
        }

        public void Test2(string sDirectory, EncyclopediaArticleType articleType)
        {
            EncyclopediaManager pManager = new EncyclopediaManager();
            pManager.Save(sDirectory, articleType);
        }
    }
}
