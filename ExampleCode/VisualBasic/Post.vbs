'URL to open....
sUrl = "http://rsense-dev.cs.uml.edu/api/v1/projects/926/jsonDataUpload"
'POST Request to send.
sRequest = "title=test&contribution_key=Key&contributor_name=Tyler&data={4248}"
HTTPPost sUrl, sRequest

Function HTTPPost(sUrl, sRequest)
  set oHTTP = CreateObject("Microsoft.XMLHTTP")
  oHTTP.open "POST", sUrl,false
  oHTTP.setRequestHeader "Content-Type", "application/x-www-form-urlencoded"
  oHTTP.setRequestHeader "Content-Length", Len(sRequest)
  oHTTP.send sRequest
  HTTPPost = oHTTP.responseText
 End Function
 