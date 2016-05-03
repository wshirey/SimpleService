node {
  stage 'Checkout'
  checkout scm
  
  stage 'Download packages'
  sh nuget restore
  
  stage 'Build Project'
  sh xbuild SimpleService.sln
}