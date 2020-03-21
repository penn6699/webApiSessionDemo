using System;
using System.Web;
using System.Web.SessionState;

/// <summary>
/// 会话助手
/// </summary>
public sealed class SessionHelper : IRequiresSessionState
{

    #region base

    /// <summary>
    /// 当前Http请求
    /// </summary>
    public static HttpRequest Request
    {
        get { return HttpContext.Current.Request; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static HttpServerUtility Server
    {
        get { return HttpContext.Current.Server; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static HttpResponse Response
    {
        get { return HttpContext.Current.Response; }
    }

    /// <summary>
    /// 
    /// </summary>
    public static HttpSessionState Session
    {
        get { return HttpContext.Current.Session; }
    }

    /// <summary>
    /// 设置键值
    /// </summary>
    /// <param name="key">键名</param>
    /// <param name="value">键值</param>
    public static void Set(string key, object value)
    {
        if (!string.IsNullOrEmpty(key) && value != null)
        {
            Session[key] = value;
        }
    }
    /// <summary>
    /// 获取键值
    /// </summary>
    /// <param name="key">键名</param>
    /// <returns></returns>
    public static object Get(string key)
    {
        return Session[key];
    }
    /// <summary>
    /// 获取键值
    /// </summary>
    /// <typeparam name="T">泛型类</typeparam>
    /// <param name="key">键名</param>
    /// <returns></returns>
    public static T Get<T>(string key)
    {
        if (!IsExist(key))
        {
            throw new Exception("Session 中不存在键“" + key + "”。");
        }
        try
        {
            return (T)Session[key];
        }
        catch
        {
            return default(T);
        }
    }

    /// <summary>
    /// 判断是否存在键值
    /// </summary>
    /// <param name="key">键名</param>
    /// <returns></returns>
    public static bool IsExist(string key)
    {
        return Session[key] != null;
    }

    #endregion




}







