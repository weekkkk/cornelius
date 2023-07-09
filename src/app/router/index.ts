import * as pages from '@/pages'
import { createRouter, createWebHistory } from 'vue-router'
import { routerLinks } from './names'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: routerLinks.MAIN.name,
      component: pages.MainPage
    },
    {
      path: '/equipment',
      name: routerLinks.EQUIPMENT.name,
      component: pages.EquipmentPage
    },
    {
      path: '/design',
      children: [
        {
          path: '',
          name: routerLinks.DESIGN.name,
          component: pages.AccreditationsPage
        },
        {
          path: 'accredidations',
          name: routerLinks.DESIGN.children.ACCREDITATIONS.name,
          component: pages.AccreditationsPage
        }
      ]
    },
    {
      path: '/news',
      name: routerLinks.NEWS.name,
      component: pages.NewsPage
    },
    {
      path: '/contacts',
      name: routerLinks.CONTACTS.name,
      component: pages.ContactsPage
    }
  ]
})

export { router }
