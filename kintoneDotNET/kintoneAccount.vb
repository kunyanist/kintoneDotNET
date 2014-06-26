Namespace API

    ''' <summary>
    ''' kintoneアカウント情報を格納するためのクラス。
    ''' コンストラクタが読み込むapp.configの設定を上書き可能
    ''' </summary>
    ''' <remarks></remarks>
    Public Class kintoneAccount

        ''' <summary>
        ''' アプリケーションのドメイン
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Domain As String = ""

        ''' <summary>
        ''' Basic認証のためのID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AccessId As String = ""

        ''' <summary>
        ''' Basic認証のためのパスワード
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property AccessPassword As String = ""

        ''' <summary>
        ''' kintoneのログインを行うためのID
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property LoginId As String = ""

        ''' <summary>
        ''' kintoneのログインを行うためのパスワード
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property LoginPassword As String = ""

        ''' <summary>
        ''' Proxyを経由する場合のアドレス
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Proxy As String = ""

        ''' <summary>
        ''' 認証が必要なプロキシの場合のユーザー名
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ProxyUser As String = ""

        ''' <summary>
        ''' 認証が必要なプロキシの場合のパスワード
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property ProxyPassword As String = ""

        Public Sub New()
            If ConfigurationManager.AppSettings.AllKeys.Contains("ktDomain") = True Then
                _Domain = ConfigurationManager.AppSettings("ktDomain")
            End If
            If ConfigurationManager.AppSettings.AllKeys.Contains("ktAccessId") = True Then
                _AccessId = ConfigurationManager.AppSettings("ktAccessId")
            End If
            If ConfigurationManager.AppSettings.AllKeys.Contains("ktAccessPassword") = True Then
                _AccessPassword = ConfigurationManager.AppSettings("ktAccessPassword")
            End If
            If ConfigurationManager.AppSettings.AllKeys.Contains("ktLoginId") = True Then
                _LoginId = ConfigurationManager.AppSettings("ktLoginId")
            End If
            If ConfigurationManager.AppSettings.AllKeys.Contains("ktLoginId") = True Then
                _LoginPassword = ConfigurationManager.AppSettings("ktLoginId")
            End If
            If ConfigurationManager.AppSettings.AllKeys.Contains("proxy") = True Then
                _Proxy = ConfigurationManager.AppSettings("proxy")
            End If
            If ConfigurationManager.AppSettings.AllKeys.Contains("proxyUser") = True Then
                _ProxyUser = ConfigurationManager.AppSettings("proxyUser")
            End If
            If ConfigurationManager.AppSettings.AllKeys.Contains("proxyPassword") = True Then
                _ProxyPassword = ConfigurationManager.AppSettings("proxyPassword")
            End If
        End Sub

    End Class

End Namespace
