import { createRouter, createWebHistory } from 'vue-router'
import { nextTick } from 'vue'
import * as pages from '@/pages'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      component: pages.MainPage
    }
  ],
  scrollBehavior: (to, from, savedPosition) => {
    if (to.hash) {
      return {
        el: to.hash
      }
    }
    return { left: 0, top: 0 }
  }
})

export { router }
