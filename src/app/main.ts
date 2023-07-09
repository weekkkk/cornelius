import { createApp } from 'vue'
import { createPinia } from 'pinia'

import { Fonts, Styles } from './assets'
Styles
Fonts

import App from './App.vue'
import { router } from './router'

const app = createApp(App)

const pinia = createPinia()

app.use(pinia)
app.use(router)

app.mount('#app')
