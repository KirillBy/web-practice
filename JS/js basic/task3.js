      
      const path = "/users/download/index.html";

      console.log(isHtml(path))
     function isHtml(pth)
     {
        var parts, ext = ( parts = pth.split("/").pop().split(".") ).length > 1 ? parts.pop() : "";   
        return ext == "html";
     }