var sam;(()=>{"use strict";var e,r,t={341:(e,r,t)=>{var o={SAM:()=>t.e(59).then((()=>()=>t(59)))},a=(e,r)=>(t.R=r,r=t.o(o,e)?o[e]():Promise.resolve().then((()=>{throw new Error('Module "'+e+'" does not exist in container.')})),t.R=void 0,r),n=(e,r)=>{if(t.S){var o="default",a=t.S[o];if(a&&a!==e)throw new Error("Container initialization failed as it has already been initialized with a different share scope");return t.S[o]=e,t.I(o,r)}};t.d(r,{get:()=>a,init:()=>n})}},o={};function a(e){var r=o[e];if(void 0!==r)return r.exports;var n=o[e]={exports:{}};return t[e](n,n.exports,a),n.exports}a.m=t,a.c=o,a.d=(e,r)=>{for(var t in r)a.o(r,t)&&!a.o(e,t)&&Object.defineProperty(e,t,{enumerable:!0,get:r[t]})},a.f={},a.e=e=>Promise.all(Object.keys(a.f).reduce(((r,t)=>(a.f[t](e,r),r)),[])),a.u=e=>e+".bundle.js",a.o=(e,r)=>Object.prototype.hasOwnProperty.call(e,r),e={},r="@ccx-public/shared-asset-model-js-cdn:",a.l=(t,o,n,i)=>{if(e[t])e[t].push(o);else{var s,d;if(void 0!==n)for(var l=document.getElementsByTagName("script"),u=0;u<l.length;u++){var c=l[u];if(c.getAttribute("src")==t||c.getAttribute("data-webpack")==r+n){s=c;break}}s||(d=!0,(s=document.createElement("script")).charset="utf-8",s.timeout=120,a.nc&&s.setAttribute("nonce",a.nc),s.setAttribute("data-webpack",r+n),s.src=t),e[t]=[o];var p=(r,o)=>{s.onerror=s.onload=null,clearTimeout(f);var a=e[t];if(delete e[t],s.parentNode&&s.parentNode.removeChild(s),a&&a.forEach((e=>e(o))),r)return r(o)},f=setTimeout(p.bind(null,void 0,{type:"timeout",target:s}),12e4);s.onerror=p.bind(null,s.onerror),s.onload=p.bind(null,s.onload),d&&document.head.appendChild(s)}},a.r=e=>{"undefined"!=typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},(()=>{a.S={};var e={},r={};a.I=(t,o)=>{o||(o=[]);var n=r[t];if(n||(n=r[t]={}),!(o.indexOf(n)>=0)){if(o.push(n),e[t])return e[t];a.o(a.S,t)||(a.S[t]={}),a.S[t];var i=[];return e[t]=i.length?Promise.all(i).then((()=>e[t]=1)):1}}})(),a.p="https://shared-components.adobe.com/sam-js/10.0.185/dist/",(()=>{var e={988:0};a.f.j=(r,t)=>{var o=a.o(e,r)?e[r]:void 0;if(0!==o)if(o)t.push(o[2]);else{var n=new Promise(((t,a)=>o=e[r]=[t,a]));t.push(o[2]=n);var i=a.p+a.u(r),s=new Error;a.l(i,(t=>{if(a.o(e,r)&&(0!==(o=e[r])&&(e[r]=void 0),o)){var n=t&&("load"===t.type?"missing":t.type),i=t&&t.target&&t.target.src;s.message="Loading chunk "+r+" failed.\n("+n+": "+i+")",s.name="ChunkLoadError",s.type=n,s.request=i,o[1](s)}}),"chunk-"+r,r)}};var r=(r,t)=>{var o,n,[i,s,d]=t,l=0;if(i.some((r=>0!==e[r]))){for(o in s)a.o(s,o)&&(a.m[o]=s[o]);d&&d(a)}for(r&&r(t);l<i.length;l++)n=i[l],a.o(e,n)&&e[n]&&e[n][0](),e[n]=0},t=self.webpackChunk_ccx_public_shared_asset_model_js_cdn=self.webpackChunk_ccx_public_shared_asset_model_js_cdn||[];t.forEach(r.bind(null,0)),t.push=r.bind(null,t.push.bind(t))})();var n=a(341);sam=n})();

(function snapshot() {
  var key = '__component_loader_versions__';
  var versions = {"AssetBrowser":{"version":"4.8.1-1"},"MiniAppBeManagePeople":{"version":"2.6.0"},"ShareSheet":{"version":"30.23.0"},"ProfileSwitcherMiniApp":{"version":"1.9.0"},"AccountMenuTrigger":{"version":"1.22.2"},"Timeline":{"version":"4.1.37"},"Commenting":{"version":"30.8.5"},"ProfileSwitcherTrigger":{"version":"1.5.1"},"AccountMenuMiniApp":{"version":"1.26.0"},"react-mini-app-overlay-test":{"version":"0.1.0"},"SAM":{"version":"10.0.185"}}
  var moduleName = 'SAM'
  if (globalThis[key]) {
      if (JSON.stringify(globalThis[key]) !== JSON.stringify(versions)) {
        globalThis[key][moduleName].updateRequired = true;
      }
  } else {
    globalThis[key] = versions;
  }
})();
      //# sourceMappingURL=remoteEntry.js.map