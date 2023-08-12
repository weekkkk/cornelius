import { defineAsyncComponent } from 'vue'
export const PageList = defineAsyncComponent(() => import('./PageList.vue'))
export * from './components'