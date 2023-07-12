import { defineAsyncComponent } from 'vue'
const PagesNavbar = defineAsyncComponent(() => import('./PagesNavbar.vue'))
export { PagesNavbar }
