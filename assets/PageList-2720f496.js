import{_ as v}from"./index-eb32faa7.js";import{d as h,b as w,n as _,q as x,s as P,r as A,t as L,v as E,x as M,o as l,c as f,F as k,y as B,h as I,u as S}from"./main-9daf253c.js";const $=h(()=>v(()=>import("./PageLi-cede17c8.js"),["assets/PageLi-cede17c8.js","assets/main-9daf253c.js","assets/index-eb32faa7.js","assets/main-86f0f4a9.css","assets/PageLi-c8df9630.css"])),y={class:"page_list f fd-col"},b=w({__name:"PageList",props:{pages:{}},setup(m){const s=m,u=_(),g=x(),r=P(()=>s.pages.find(t=>`#${t.id}`==u.hash)),d=A(!1),a=L("isAnim"),c=()=>{if(a.value)return;const t=window.scrollY,e=Number((t/window.innerHeight).toFixed(1));if(!r.value)return;let n=0;const o=s.pages.indexOf(r.value);window.innerWidth<=800?n=e<o?Math.ceil(e):Math.floor(e):n=e<o?Math.floor(e):Math.ceil(e);const i=s.pages[n];if(!r)return;const p=`#${i.id}`;u.hash!=p&&(d.value=!1,window.innerWidth<800&&(d.value=!0),g.replace({hash:p}))};return E(()=>{window.addEventListener("scroll",c)}),M(()=>{window.removeEventListener("scroll",c)}),(t,e)=>(l(),f("div",y,[(l(!0),f(k,null,B(t.pages,(n,o)=>(l(),I(S($),{onStartAnim:e[0]||(e[0]=i=>a.value=!0),onStopAnim:e[1]||(e[1]=i=>a.value=!1),key:n.id,page:n,index:o},null,8,["page","index"]))),128))]))}});export{b as default};
