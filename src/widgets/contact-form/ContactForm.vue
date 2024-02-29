<script lang="ts" setup>
import { computed, onMounted, ref } from 'vue'
import type { ContactType } from './types'
import { reactive } from 'vue'
import { MailService } from '@/shared'
import { send } from './mail'

const contact: ContactType = reactive({
  phone: '',
  name: '',
  message: ''
})

const isLoading = ref(false)

const sendMail = async () => {
  isLoading.value = true

  await send(contact)

  isLoading.value = false

  emit('success')
}

const emit = defineEmits<{
  (e: 'success'): void
}>()

const phoneError = computed(() => {
  if (!contact.phone) return 'Номер телефона является обязательным полем формы'
})
</script>

<template>
  <form action="" class="contact_form f fd-col rg-4">
    <input class="contact_form-input" type="text" placeholder="Ваш телефон" />
    <input class="contact_form-input" type="text" placeholder="Ваше имя" />
    <input class="contact_form-input" type="text" placeholder="Ваше сообщение" />
    <button :disabled="isLoading || !!phoneError">Отправить</button>
  </form>
</template>

<style lang="scss" scoped>
.contact_form {
  &-input {
    border: 1px solid var(--n-second-50);
    outline: none;
    padding: 1rem;
    text-align: center;
    font-family: inherit;
    transition: 0.2s ease-in-out;
    &:focus {
      border-color: var(--n-brand);
    }
  }
}
</style>
