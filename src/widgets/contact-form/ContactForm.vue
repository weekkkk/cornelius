<script lang="ts" setup>
import { computed, onMounted, ref } from 'vue'
import type { ContactType } from './types'
import { reactive } from 'vue'
import { MailService } from '@/shared'
import { Email } from './smtp'

const contact: ContactType = reactive({
  phone: '',
  name: '',
  message: ''
})

// const mailService = new MailService()

const isLoading = ref(false)

const sendMail = () => {
  isLoading.value = true

  const formData = new FormData()
  formData.append('from', 'nikita.nedelko.job@gmail.com') // Replace with your email address
  formData.append('to', 'nikita.nedelko.life@gmail.com') // Replace with the recipient's email address
  formData.append('subject', 'Test email') // Replace with the subject of your email
  formData.append('text', 'Hello, this is a test email.') // Replace with the body of your email

  fetch('https://api.mailgun.net/v3/YOUR_DOMAIN_NAME/messages', {
    method: 'POST',
    headers: {
      Authorization: 'Basic ' + btoa('api:YOUR_API_KEY') // Замените YOUR_API_KEY на ваш API-ключ Mailgun
    },
    body: formData
  })
    .then((response) => {
      if (response.ok) {
        console.log('Сообщение успешно отправлено')
      } else {
        console.error('Ошибка при отправке сообщения:', response.statusText)
      }
    })
    .catch((error) => {
      console.error('Ошибка при отправке сообщения:', error)
    })
    .finally(() => {
      isLoading.value
    })

  // Email.send({
  //   Host: 'smtp.elasticemail.com',
  //   Username: 'username',
  //   Password: 'password',
  //   To: 'them@website.com',
  //   From: 'you@isp.com',
  //   Subject: 'This is the subject',
  //   Body: 'And this is the body'
  // })

  // await mailService.sendMail({
  //   from: '"Fred Foo 👻" <foo@example.com>',
  //   to: 'nikita.nedelko.job@gmail.com',
  //   subject: 'Hello ✔', // Subject line
  //   text: 'Hello world?', // plain text body
  //   html: '<b>Hello world?</b>' // html body
  // })
  // emit('success')
}

const emit = defineEmits<{
  (e: 'success'): void
}>()

const phoneError = computed(() => {
  if (!contact.phone) return 'Номер телефона является обязательным полем формы'
})
</script>

<template>
  <div class="contact_form f fd-col ai-fs rg-4">
    <div class="f fd-col rg-3 w-100">
      <div class="f fd-col rg-2">
        <input v-model="contact.phone" type="text" placeholder="Введите ваше телефон" />
      </div>
      <input
        v-model="contact.name"
        type="text"
        placeholder="Введите ваше имя"
        :disabled="!!phoneError"
      />
      <input
        v-model="contact.message"
        type="text"
        placeholder="Введите ваше сообщение"
        :disabled="!!phoneError"
      />
    </div>

    <button @click="sendMail" class="px-5" :disabled="!!phoneError">
      <span v-if="!isLoading"> Отправить </span>

      <div class="button-loader" v-else>
        <div class="left"></div>
        <div class="center"></div>
        <div class="right"></div>
      </div>
    </button>
  </div>
</template>

<style lang="scss" scoped>
.contact_form {
  input {
    outline: none;
    border: none;
    border-bottom: 1px solid var(--n-second-50);
    font-family: inherit;
    font-size: inherit;
    padding: 12px 8px;
    &:disabled {
      opacity: 0.75;
      background-color: var(--n-second-0);
    }
  }
  > button {
    width: calc(100% / 3);
    &:disabled {
      opacity: 0.75;
    }
  }
  @media (max-width: 800px) {
    font-size: 12px;
    row-gap: 16px;
    > div {
      row-gap: 8px;
    }
    > button {
      padding-top: 8px;
      padding-bottom: 8px;
      width: 100%;
    }
  }
}
</style>

<style lang="scss">
@keyframes point {
  0% {
    opacity: 0.25;
  }

  25% {
    opacity: 1;
  }

  50% {
    opacity: 0.25;
  }
}
.button-loader {
  min-height: 8px;
  display: flex;
  align-items: center;
  gap: 8px;

  > * {
    background-color: #fff;
  }

  .left,
  .center,
  .right {
    content: '';
    display: inline-grid;
    min-height: 8px;
    min-width: 8px;
    max-height: 8px;
    max-width: 8px;
    border-radius: 50%;
    animation: point 1s ease-in-out infinite;
    opacity: 0.25;
  }

  .left {
    animation-delay: 0s;
  }

  .center {
    animation-delay: 0.16s;
  }

  .right {
    animation-delay: 0.32s;
  }
}
</style>
