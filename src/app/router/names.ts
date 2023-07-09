export const routerLinks = {
  MAIN: { name: 'main', title: 'Главная' },
  EQUIPMENT: { name: 'equipment', title: 'Оборудование' },
  DESIGN: {
    name: 'design',
    title: 'Проектирование',
    children: {
      ACCREDITATIONS: { name: 'design-accreditations', title: 'Акредитации' }
    }
  },
  NEWS: { name: 'news', title: 'Новости' },
  CONTACTS: { name: 'contacts', title: 'Контакты' }
}
