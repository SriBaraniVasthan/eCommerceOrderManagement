function login()
{
   
     if(document.getElementById("ContentPlaceHolder1_txtUserID").value == "")
    {
        alert("Please enter User id");
        return false
    }
    if(document.getElementById("ContentPlaceHolder1_txtPassword").value == "")
    {
        alert("Please enter Password");
        return false

      
        
    }

    return true
}