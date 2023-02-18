import type { RouteRecordRaw } from 'vue-router';
import { ORDER } from './names';
/**
 * * Контакты
 */
const Contacts: RouteRecordRaw = {
  name: ORDER,
  path: ORDER,
  meta: { Title: 'Контакты' },
  component: () => import('@/pages/contacts-page.vue'),
};
export default Contacts;
