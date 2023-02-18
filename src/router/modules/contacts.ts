import type { RouteRecordRaw } from 'vue-router';
import { CONTACTS } from './names';
/**
 * * Контакты
 */
const Contacts: RouteRecordRaw = {
  name: CONTACTS,
  path: CONTACTS,
  meta: { Title: 'Контакты' },
  component: () => import('@/pages/contacts-page.vue'),
};
export default Contacts;
