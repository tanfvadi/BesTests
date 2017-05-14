// Decompiled with JetBrains decompiler
// Type: PageObject3.Pages.NotOnExpectedPageException
// Assembly: PageObject3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0D9DC055-2B5D-4B03-9C15-724F3DFE242F
// Assembly location: C:\Users\vadim.t.ECB\Documents\Visual Studio 2015\Projects\PageObject3\PageObject3\bin\Debug\PageObject3.dll

using System;
using System.Runtime.Serialization;

namespace PageObject3.Pages
{
  [Serializable]
  public class NotOnExpectedPageException : Exception
  {
    public NotOnExpectedPageException()
    {
    }

    public NotOnExpectedPageException(string message)
      : base(message)
    {
    }

    public NotOnExpectedPageException(string message, Exception innerException)
      : base(message, innerException)
    {
    }

    protected NotOnExpectedPageException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }
  }
}
