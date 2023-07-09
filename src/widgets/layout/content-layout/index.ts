import { defineAsyncComponent } from 'vue'
const ContentLayout = defineAsyncComponent(() => import('./ContentLayout.vue'))
export { ContentLayout }
