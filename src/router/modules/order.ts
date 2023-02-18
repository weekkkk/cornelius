import type { RouteRecordRaw } from 'vue-router';
import { ORDER } from './names';
/**
 * * Заказ
 */
const Order: RouteRecordRaw = {
  name: ORDER,
  path: ORDER,
  meta: { Title: 'Заказ' },
  component: () => import('@/pages/order-page.vue'),
};
export default Order;
