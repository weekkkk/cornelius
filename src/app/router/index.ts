import { MainPage } from '@/pages'
import { createRouter, createWebHistory } from 'vue-router'
import { MAIN } from './names'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: MAIN,
      component: MainPage
    }
  ]
})

export { router }
