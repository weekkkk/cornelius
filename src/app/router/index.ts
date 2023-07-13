import { createRouter, createWebHistory } from 'vue-router'
import { LandingLayout } from '@/widgets'
import { nextTick } from 'vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      component: LandingLayout,
    }
  ],
  scrollBehavior: async (to, from, savedPosition) => {
    await nextTick()

    if (to.hash) {
      const element = document.querySelector(to.hash) as HTMLElement

      if (element) {
        const index = Number(element.ariaRowIndex) || 0

        if (window.innerWidth > 800) {
          window.scrollTo({ top: window.innerHeight * index })
        }
        
        return {
          el: to.hash,
        }
      } else if (savedPosition) {
        return savedPosition
      }
    }
    return { left: 0, top: 0 }
  }
})

export { router }
