import { createRouter, createWebHistory } from 'vue-router'
import { LandingLayout } from '@/widgets'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      component: LandingLayout
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
