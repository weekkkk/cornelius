import { createRouter, createWebHistory } from 'vue-router'
import { LandingLayout } from '@/widgets'
import { nextTick } from 'vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      component: LandingLayout
    }
  ],
  scrollBehavior: async (to, from, savedPosition) => {
    await nextTick()
    console.log(savedPosition)
    console.log(to.hash);
    

    if (to.hash) {
      const element = document.querySelector(to.hash)

      if (element) {
        return {
          el: to.hash,
          top: savedPosition?.top
        }
      } else if (savedPosition) {
        return savedPosition
      }
    }
    return { left: 0, top: 0 }
  }
})

export { router }
