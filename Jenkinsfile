node {
  stage 'Checkout'
  checkout scm
  
  stage 'Download packages'
<<<<<<< HEAD
  sh "nuget restore"
  
  stage 'Build Project'
  sh "xbuild SimpleService.sln"
=======
  sh nuget restore
  
  stage 'Build Project'
  sh xbuild SimpleService.sln
>>>>>>> c348d3215841587bc31e10169ab799cf0abf497f
}