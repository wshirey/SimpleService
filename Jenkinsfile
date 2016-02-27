node {
  stage 'Checkout'
  checkout scm
  
  stage 'Download packages'
  nuget restore
  
  stage 'Build Project'
  xbuild SimpleService.sln
}